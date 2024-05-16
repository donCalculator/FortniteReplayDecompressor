using Unreal.Core.Attributes;
using Unreal.Core.Contracts;
using Unreal.Core.Models;
using Unreal.Core.Models.Enums;

namespace FortniteReplayReader.Models.NetFieldExports;

[NetFieldExportGroup("/Script/FortniteGame.FortPlayerStateComponent_Habanero", minimalParseMode: ParseMode.Normal)]
public class HabaneroPlayerStateComponent : INetFieldExportGroup
{
    [NetFieldExport("Rank", RepLayoutCmdType.PropertyInt)]
    public int? Rank { get; set; }

    [NetFieldExport("RankType", RepLayoutCmdType.PropertyString)]
    public string? RankType { get; set; }

}