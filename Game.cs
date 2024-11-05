using System.Numerics;
using AoTTG2_Custom_Logic.PlayerObjects;
//using function = System.Threading.Tasks.Task;

namespace AoTTG2_Custom_Logic;

interface IGame
{
    #region Fields

    /// <summary>
    /// Is the game currently ending.
    /// </summary>
    public bool IsEnding { get; }

    /// <summary>
    /// Time left before game restarts.
    /// </summary>
    public float EndTimeLeft { get; }

    /// <summary>
    /// List of titans currently alive.
    /// </summary>
    public List<Titan> Titans { get; }

    /// <summary>
    /// List of shifters currently alive.
    /// </summary>
    public List<Shifter> Shifters { get; }

    /// <summary>
    /// List of humans currently alive.
    /// </summary>
    public List<Human> Humans { get; }

    /// <summary>
    /// List of AI titans currently alive.
    /// </summary>
    public List<AiTitan> AiTitans { get; }

    public List<AiShifters> AiShifters { get; }

    public List<AiHumans> AiHumans { get; }

    public List<PlayerTitan> PlayerTitans { get; }

    public List<PlayerShifter> PlayerShifters { get; }

    public List<PlayerHuman> PlayerHumans { get; }

    /// <summary>
    /// List of allowed player loadouts.
    /// </summary>
    public List<string> Loadouts { get; }

    public bool ShowScoreboardStatus { get; set; }
    public bool ShowScoreboardLoadout { get; set; }
    public bool ForcedCharacterType { get; set; }
    public bool ForcedLoadout { get; set; }

    #endregion


    #region functions

    function Debug(string message);
    function Print(string message);
    function PrintAll(string message);
    function End(float delay);
    function<Titan> SpawnTitan(string type);
    function SpawnTitanAt(string type, Vector3 position, float? rotationY = null);
    function<List<Titan>> SpawnTitans(string type, int amount);
    function<List<Titan>> SpawnTitansAt(string type, int amount, Vector3 position, float? rotationY = null);

    function SpawnTitansAsync(string type, int amount);
    
    function SpawnTitansAtAsync(string type, int amount, Vector3 position, float? rotationY = null);

    function<Shifter> SpawnShifter(string type);
    
    function<Shifter> SpawnShifterAt(string type, Vector3 position, float? rotationY = null);

    function SpawnPlayer(Player player, bool force);
    
    function SpawnPlayerAt(Player player, bool force, Vector3 position, float? rotationY = null);
    
    function SpawnPlayerAll(bool force);
    
    function SpawnPlayerAtAll(bool force, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Returns bool / int / float / string
    /// </summary>
    /// <param name="setting"></param>
    /// <returns></returns>
    function<object> GetGeneralSetting(string setting);

    function<object> GetTitanSetting(string setting);
    
    function<object> GetMiscSetting(string setting);
    
    function SpawnProjectile(string projectileType, Vector3 position, Vector3 rotation, Vector3? velocity, Vector3 gravity, float liveTime, string team, params object[] parameters );
    
    function SpawnProjectileWithOwner(string projectileType, Vector3 position, Vector3 rotation, Vector3? velocity, Vector3 gravity, float liveTime, string team, Character owner,params object[] parameters );
    
    function SpawnEffect(string effect, Vector3 position, Vector3 rotation, float scale, params object[] parameters);

    function SetPlaylist(string playlistName);

    function SetSong(string songName);
    
    function<Character> FindCharacterByViewID(int viewID);

    function ShowKillScore(int score);

    function ShowKillFeed(string killer, string victim, int score, string weapon);
    
    function ShowKillFeedAll(string killer, string victim, int score, string weapon);

    #endregion
}