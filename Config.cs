using CounterStrikeSharp.API.Core;

namespace CS2AutoTeam
{
    public class Config : IBasePluginConfig
    {
        public int MinPlayers { get; set; } = 0;
        public List<string> MapNames { get; set; } = new();
        
        public int Version { get; set; } = 2;
    }
}