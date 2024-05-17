using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortniteReplayReader.Models;
public class HabaneroRank
{
    public string? gameId { get; set; }
    public string? trackguid { get; set; }
    public string? accountId { get; set; }
    public string? rankingType { get; set; }
    public DateTime? lastUpdated { get; set; }
    public int? currentDivision { get; set; }
    public int? highestDivision { get; set; }
    public double? promotionProgress { get; set; }
    public int? currentPlayerRanking { get; set; }
}
