using p4g64.customSubMenu.Template.Configuration;
using System.ComponentModel;

namespace p4g64.customSubMenu.Configuration
{
    public class Config : Configurable<Config>
    {
        [DisplayName("Show Mod Menu")]
        [Description("If enabled you will be able to access the Mod Menu (make sure to also enable Mod Menu in the in-game options).\nThe Mod Menu is for mod developers and dataminers - it is NOT a \"cheats menu\" for players!\nIf you use it and break your save, you won't get help!")]
        [DefaultValue(false)]
        public bool ShowModMenu { get; set; } = false;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}