using CounterStrikeSharp.API.Core;

namespace CS2AutoTeam
{
    public class Config : IBasePluginConfig
    {
        public List<string> MapNames { get; set; } = new();
        public int Version { get; set; } = 1;
    }
}