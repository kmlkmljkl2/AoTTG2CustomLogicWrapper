using AoTTG2_Custom_Logic.PlayerObjects;

namespace AoTTG2_Custom_Logic;

public interface INetwork
{
    public bool IsMasterClient { get; }
    public List<Player> Players { get; }
    public Player MasterClient { get; }
    public Player MyPlayer { get; }
    public float NetworkTime { get; }
    
    function SendMessage(Player target, string message);
    function SendMessageAll(string message);
    function SendMessageOthers(string message);
}