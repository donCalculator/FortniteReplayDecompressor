namespace FortniteReplayReader.Models;

public class DamageCue
{
    public double? ReplicatedWorldTimeSecondsDouble { get; set; }
    public string? damageSourcePlayer { get; set; }
    public string? damageTargetPlayer { get; set; }
    public float? damageMagnitude { get; set; }
    public bool? bIsFatal { get; set; }
    public bool? bIsCritical { get; set; }
    public bool? bIsShield { get; set; }
    public bool? bIsShieldDestroyed { get; set; }
    public bool? bIsHitActorPlayer { get; set; }
}
