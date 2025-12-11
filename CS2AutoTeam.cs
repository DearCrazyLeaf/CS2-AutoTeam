using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Config;
using CounterStrikeSharp.API.Modules.Utils;

namespace CS2AutoTeam
{
    public class AutoTeamPlugin : BasePlugin, IPluginConfig<Config>
    {
        public override string ModuleName => "CS2AutoTeam";
        public override string ModuleVersion => "1.5.0";
        public override string ModuleAuthor => "DearCrazyLeaf";
        public override string ModuleDescription => "Automatically assigns players to a random team when they join the server, only on configured maps";

        public required Config Config { get; set; }

        public void OnConfigParsed(Config config)
        {
            Config = config;
        }

        public override void Load(bool hotReload)
        {
            RegisterEventHandler<EventPlayerConnectFull>(OnPlayerConnectFull);
        }

        private HookResult OnPlayerConnectFull(EventPlayerConnectFull @event, GameEventInfo info)
        {
            var currentMap = Server.MapName;

            // 检查当前地图是否在配置列表中（支持部分匹配，如 workshop 地图）
            bool isMapEnabled = Config.MapNames.Any(configMap =>
                currentMap.Contains(configMap, StringComparison.OrdinalIgnoreCase) ||
                configMap.Equals(currentMap, StringComparison.OrdinalIgnoreCase));

            // 获取当前服务器玩家数量
            var playerCount = Utilities.GetPlayers().Count(p => p.IsValid && !p.IsBot && !p.IsHLTV);

            // 检查人数是否达到最少玩家数（0 表示不限制）
            bool isThresholdMet = Config.MinPlayers <= 0 || playerCount >= Config.MinPlayers;

            if (isMapEnabled && isThresholdMet)
            {
                var player = @event.Userid;
                if (player != null && player.IsValid)
                {
                    // 2=CT, 3=T
                    var teamId = Random.Shared.Next(2, 4);
                    player.ChangeTeam((CsTeam)teamId);
                    var teamName = Localizer[$"team_name.{teamId}"];
                    var msg = Localizer["player_assigned_team", player.PlayerName, teamName];
                    Server.PrintToChatAll(msg);
                }
            }
            return HookResult.Continue;
        }
    }
}