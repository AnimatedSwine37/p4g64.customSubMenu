using p4g64.customSubMenu.Template.Configuration;
using System.ComponentModel;

namespace p4g64.customSubMenu.Configuration
{
    public class Config : Configurable<Config>
    {
        [DisplayName("Show Mod Menu")]
        [Description("If enabled you will be able to use the mod menu (you still need to enable it in the in-game options).\nNote that mod menu is only meant for mod developers, if you use it and break your save you won't get help!")]
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