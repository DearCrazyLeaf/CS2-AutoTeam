using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Config;
using CounterStrikeSharp.API.Modules.Utils;

namespace CS2AutoTeam
{
    public class AutoTeamPlugin : BasePlugin, IPluginConfig<Config>
    {
        public override string ModuleName => "CS2AutoTeam";
        public override string ModuleVersion => "1.0.0";
        public override string ModuleAuthor => "DearCrazyLeaf";
        public override string ModuleDescription => "Automatically assigns players to a random team when they join the server, only on configured maps";

        public required Config Config { get; set; }

        public void OnConfigParsed(Config config)
        {
            Config = config;
        }

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventPlayerConnect>((@event, info) =>
            {
                var mapName = Server.MapName;
                if (Config.MapNames.Contains(mapName, StringComparer.OrdinalIgnoreCase))
                {
                    var player = @event.Userid;
                    if (player != null && player.IsValid)
                    {
                        // 2=CT, 3=T
                        var teamId = Random.Shared.Next(2, 4);
                        player.ChangeTeam((CsTeam)teamId);
                        var teamName = Localizer["team_name", (CsTeam)teamId];
                        var msg = Localizer["player_assigned_team", player.PlayerName, teamName];
                        Server.PrintToChatAll(msg);
                    }
                }
                return HookResult.Continue;
            });
        }
    }
}