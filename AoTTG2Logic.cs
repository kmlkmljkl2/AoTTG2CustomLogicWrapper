using System.Numerics;
using AoTTG2_Custom_Logic.PlayerObjects;

namespace AoTTG2_Custom_Logic;

/// <summary>
/// Class that will be inherited for the GameLogic
/// </summary>
public class AoTTG2Logic : IGame
{
    public bool IsEnding { get; }
    public float EndTimeLeft { get; }
    public List<Titan> Titans { get; }
    public List<Shifter> Shifters { get; }
    public List<Human> Humans { get; }
    public List<AiTitan> AiTitans { get; }
    public List<AiShifters> AiShifters { get; }
    public List<AiHumans> AiHumans { get; }
    public List<PlayerTitan> PlayerTitans { get; }
    public List<PlayerShifter> PlayerShifters { get; }
    public List<PlayerHuman> PlayerHumans { get; }
    public List<string> Loadouts { get; }
    public bool ShowScoreboardStatus { get; set; }
    public bool ShowScoreboardLoadout { get; set; }
    public bool ForcedCharacterType { get; set; }
    public bool ForcedLoadout { get; set; }
    
    public function Debug(string message)
    {
        throw new NotImplementedException();
    }

    public function Print(string message)
    {
        throw new NotImplementedException();
    }

    public function PrintAll(string message)
    {
        throw new NotImplementedException();
    }

    public function End(float delay)
    {
        throw new NotImplementedException();
    }

    public function<Titan> SpawnTitan(string type)
    {
        throw new NotImplementedException();
    }

    public function SpawnTitanAt(string type, Vector3 position, float? rotationY = null)
    {
        throw new NotImplementedException();
    }

    public function SpawnTitans(string type, int amount)
    {
        throw new NotImplementedException();
    }

    public function SpawnTitansAt(string type, int amount, Vector3 position, float? rotationY = null)
    {
        throw new NotImplementedException();
    }
}