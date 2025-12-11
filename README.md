# CS2-AutoTeam

[![中文版介绍](https://img.shields.io/badge/跳转到中文版-中文介绍-red)](#中文版介绍)
[![Release](https://img.shields.io/github/v/release/DearCrazyLeaf/CS2-AutoTeam?include_prereleases&color=blueviolet)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/releases/latest)
[![License](https://img.shields.io/badge/License-GPL%203.0-orange)](https://www.gnu.org/licenses/gpl-3.0.txt)
[![Issues](https://img.shields.io/github/issues/DearCrazyLeaf/CS2-AutoTeam?color=darkgreen)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/issues)
[![Pull Requests](https://img.shields.io/github/issues-pr/DearCrazyLeaf/CS2-AutoTeam?color=blue)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/pulls)
[![Downloads](https://img.shields.io/github/downloads/DearCrazyLeaf/CS2-AutoTeam/total?color=brightgreen)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/releases)
[![GitHub Stars](https://img.shields.io/github/stars/DearCrazyLeaf/CS2-AutoTeam?color=yellow)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/stargazers)

## CS2-AutoTeam

**CS2-AutoTeam is a CS2 plugin that automatically assigns players to a random team (T or CT) when they join the server, only on maps specified in the configuration file.**

## Features

- Automatically assign players to a random team when they join the server
- Only works on specified maps
- Multi-language support
- Configurable map list
- Configurable minimum player count to enable the feature

## Configuration

| Option | Type | Default | Description |
|--------|------|---------|-------------|
| `MinPlayers` | int | 0 | Minimum number of players required to enable auto team assignment. Set to 0 to disable this limit|
| `MapNames` | string[] | [] | List of map names where the plugin is enabled. Supports partial matching (e.g., `de_dust2`)|
| `Version` | int | 1 | Don't change this|

**Example configuration:**
```json
{
  "MinPlayers": 10,
  "MapNames": [
    "de_dust2",
    "de_mirage",
    "de_inferno"
  ],
  "Version": 1
}
```

## How to use

- Place the plugin and configuration files in the appropriate directories
- Edit the configuration file to set the map names you want the plugin to work on
- To customize language, add or modify language files in the `lang` folder

## Requirements

- [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp)

## Contributing

If you have suggestions, bug reports, or improvements, feel free to submit an Issue or Pull Request.

## License

<a href="https://www.gnu.org/licenses/gpl-3.0.txt" target="_blank" style="margin-left: 10px; text-decoration: none;">
    <img src="https://img.shields.io/badge/License-GPL%203.0-orange?style=for-the-badge&logo=gnu" alt="GPL v3 License">
</a>

---

# 中文版介绍 

[![English Version](https://img.shields.io/badge/Back_to_English-English-blue)](#CS2-AutoTeam)
[![Release](https://img.shields.io/github/v/release/DearCrazyLeaf/CS2-AutoTeam?include_prereleases&color=blueviolet&label=最新版本)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/releases/latest)
[![License](https://img.shields.io/badge/许可证-GPL%203.0-orange)](https://www.gnu.org/licenses/gpl-3.0.txt)
[![Issues](https://img.shields.io/github/issues/DearCrazyLeaf/CS2-AutoTeam?color=darkgreen&label=反馈)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/issues)
[![Pull Requests](https://img.shields.io/github/issues-pr/DearCrazyLeaf/CS2-AutoTeam?color=blue&label=请求)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/pulls)
[![Downloads](https://img.shields.io/github/downloads/DearCrazyLeaf/CS2-AutoTeam/total?color=brightgreen&label=下载)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/releases)
[![GitHub Stars](https://img.shields.io/github/stars/DearCrazyLeaf/CS2-AutoTeam?color=yellow&label=标星)](https://github.com/DearCrazyLeaf/CS2-AutoTeam/stargazers)

## CS2-AutoTeam

**CS2-AutoTeam 是一个 CS2 插件，能在玩家加入服务器时自动将其分配到随机阵营（T 或 CT），仅在配置文件指定的地图上生效**

## 功能特点

- 玩家加入服务器时自动分配到随机阵营
- 仅在指定地图生效
- 支持多语言
- 可配置的生效地图列表
- 可配置最少玩家人数以启用功能

## 配置说明

| 配置项 | 类型 | 默认值 | 说明 |
|--------|------|--------|------|
| `MinPlayers` | int | 0 | 启用自动分配功能的最少玩家人数。设置为 0 表示不限制人数|
| `MapNames` | string[] | [] | 启用插件的地图名称列表。支持部分匹配（如`de_dust2`）|
| `Version` | int | 1 | 请勿配置此项|

**配置示例：**
```json
{
  "MinPlayers": 10,
  "MapNames": [
    "de_dust2",
    "de_mirage",
    "de_inferno"
  ],
  "Version": 1
}
```

## 使用方法

- 将插件和配置文件放入对应目录
- 编辑配置文件，设置需要生效的地图名称
- 如需自定义语言，可在 `lang` 文件夹中添加或修改语言文件

## 要求

- [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp)

## 贡献

如果您有建议、错误报告或改进，欢迎提交 Issue 或 Pull Request。

## 许可证

<a href="https://www.gnu.org/licenses/gpl-3.0.txt" target="_blank" style="margin-left: 10px; text-decoration: none;">
    <img src="https://img.shields.io/badge/License-GPL%203.0-orange?style=for-the-badge&logo=gnu" alt="GPL v3 License">
</a>