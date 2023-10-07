using BF.File.Emulator.Interfaces;
using p4g64.customSubMenu.Configuration;
using p4g64.customSubMenu.Template;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;

namespace p4g64.customSubMenu
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {
        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded.Hooks API.
        /// </summary>
        /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
        private readonly IReloadedHooks? _hooks;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;
        private IBfEmulator _bfEmulator;

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;

            Utils.Initialise(_logger, _configuration);

            var bfEmulatorController = _modLoader.GetController<IBfEmulator>();
            if (bfEmulatorController == null || !bfEmulatorController.TryGetTarget(out _bfEmulator))
            {
                Utils.LogError($"Unable to get controller for BF Emulator, stuff won't work :(");
                return;
            }

            // Set whether mod menu should be shown or hidden
            var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);
            var flowFile = Path.Combine(modDir, "BF", $"{(_configuration.ShowModMenu ? "Show" : "Hide")}ModMenu.flow");

            _bfEmulator.AddFile(flowFile, "field.flow");
            _bfEmulator.AddFile(flowFile, "scheduler_04.flow");
            _bfEmulator.AddFile(flowFile, "scheduler_04.flow");


            // Apply Kuma patch
            var mods = _modLoader.GetActiveMods();
            if (mods.Any(x => x.Generic.ModId == "p4g64.kuma"))
            {
                Utils.Log("Found \"Replace Teddie With Kuma\", enabling compatibility mode.");
                _bfEmulator.AddDirectory(Path.Combine(modDir, "BF", "Kuma"));
            }
            else
            {
                _bfEmulator.AddDirectory(Path.Combine(modDir, "BF", "Teddie"));
                _modLoader.ModLoaded += ModLoaded;
            }

        }

        private void ModLoaded(IModV1 mod, IModConfigV1 modConfig)
        {
            if (modConfig.ModId == "p4g64.kuma")
            {
                Utils.Log("Found \"Replace Teddie With Kuma\", enabling compatibility mode.");
                var modDir = _modLoader.GetDirectoryForModId(_modConfig.ModId);
                _bfEmulator.AddDirectory(Path.Combine(modDir, "BF", "Kuma"));
            }
        }

        #region Standard Overrides
        public override void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}