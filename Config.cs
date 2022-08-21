using Exiled.API.Interfaces;
using System.ComponentModel;

public class Config : IConfig
{
    [Description("Enable or disable the plugin.")]
    public bool IsEnabled { get; set; }
}