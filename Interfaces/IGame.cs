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

    /// <summary>
    /// List of AI shifters currently alive.
    /// </summary>
    public List<AiShifters> AiShifters { get; }

    /// <summary>
    /// List of AI humans currently alive.
    /// </summary>
    public List<AiHumans> AiHumans { get; }

    /// <summary>
    /// List of player titans currently alive.
    /// </summary>
    public List<PlayerTitan> PlayerTitans { get; }

    /// <summary>
    /// List of player shifters currently alive.
    /// </summary>
    public List<PlayerShifter> PlayerShifters { get; }

    /// <summary>
    /// List of player humans currently alive.
    /// </summary>
    public List<PlayerHuman> PlayerHumans { get; }

    /// <summary>
    /// List of allowed player loadouts.
    /// </summary>
    public List<string> Loadouts { get; }

    /// <summary>
    /// Default kill score behavior. If set to false, kill scores (damage popup) will not automatically show upon player dealing character damage.
    /// </summary>
    public bool DefaultShowKillScore { get; set; }

    /// <summary>
    /// Default kill feed behavior. If set to false, kill feeds (feed popup) will not automatically show upon player kills.
    /// </summary>
    public bool DefaultShowKillFeed { get; set; }

    /// <summary>
    /// Default add score behavior. If set to false, kills will not automatically modify kills/damage/deaths stats.
    /// </summary>
    public bool DefaultAddKillScore { get; set; }

    /// <summary>
    /// Whether to show player alive/dead status in the scoreboard.
    /// </summary>
    public bool ShowScoreboardStatus { get; set; }

    /// <summary>
    /// Whether to show player character/loadout in the scoreboard.
    /// </summary>
    public bool ShowScoreboardLoadout { get; set; }

    /// <summary>
    /// The forced character for the local player. Upon next spawn or SpawnPlayer call, the player will spawn as this character instead of their chosen character. Available characters: Human, Titan, Shifter.
    /// </summary>
    public bool ForcedCharacterType { get; set; }

    /// <summary>
    /// The forced loadout for the local player. Upon next spawn, the player will spawn using this loadout. Available loadouts per character type:
    ///Shifter: Annie, Eren
    ///Titan: Small, Medium, Large
    ///Human: Blades, AHSS, APG, Thunderspears
    /// </summary>
    public bool ForcedLoadout { get; set; }

    #endregion


    #region functions

    /// <summary>
    /// Prints a message to the debug console (accessible using F11).
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    function Debug(string message);

    /// <summary>
    /// Prints a message to the chat window.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    function Print(string message);

    /// <summary>
    /// Prints a message to all players chat window.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    function PrintAll(string message);

    /// <summary>
    /// Ends the game and restarts after given delay. Master client only.
    /// </summary>
    /// <param name="delay"></param>
    /// <returns></returns>
    function End(float delay);

    /// <summary>
    /// Spawn a titan. Master client only. Valid types: "Default", "Dummy", "Normal", "Abnormal", "Punk", "Crawler", "Thrower".
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    function<Titan> SpawnTitan(string type);

    /// <summary>
    /// Spawn a titan at position. Master client only.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="position"></param>
    /// <param name="rotationY"></param>
    /// <returns></returns>
    function SpawnTitanAt(string type, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Spawn amount titans. Master client only.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    function<List<Titan>> SpawnTitans(string type, int amount);

    /// <summary>
    /// Spawn amount titans at position. Master client only.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="amount"></param>
    /// <param name="position"></param>
    /// <param name="rotationY"></param>
    /// <returns></returns>
    function<List<Titan>> SpawnTitansAt(string type, int amount, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Spawn amount titans over time. Note that no titan list is returned.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    function SpawnTitansAsync(string type, int amount);

    /// <summary>
    /// Spawn amount titans at position over time.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="amount"></param>
    /// <param name="position"></param>
    /// <param name="rotationY"></param>
    /// <returns></returns>
    function SpawnTitansAtAsync(string type, int amount, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Spawn a shifter. Master client only. Valid types: "Annie"
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    function<Shifter> SpawnShifter(string type);

    /// <summary>
    /// Spawn a shifter at position.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="position"></param>
    /// <param name="rotationY"></param>
    /// <returns></returns>
    function<Shifter> SpawnShifterAt(string type, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Spawns the given player. Must be the given player or masterclient. If force is true, will kill the existing player and respawn them, otherwise will only spawn if the player is dead.
    /// </summary>
    /// <param name="player"></param>
    /// <param name="force"></param>
    /// <returns></returns>
    function SpawnPlayer(Player player, bool force);

    /// <summary>
    /// Spawns the player at a given position.
    /// </summary>
    /// <param name="player"></param>
    /// <param name="force"></param>
    /// <param name="position"></param>
    /// <param name="rotationY"></param>
    /// <returns></returns>
    function SpawnPlayerAt(Player player, bool force, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Spawns all players. Master client only.
    /// </summary>
    /// <param name="force"></param>
    /// <returns></returns>
    function SpawnPlayerAll(bool force);

    /// <summary>
    /// Spawns all players at position.
    /// </summary>
    /// <param name="force"></param>
    /// <param name="position"></param>
    /// <param name="rotationY"></param>
    /// <returns></returns>
    function SpawnPlayerAtAll(bool force, Vector3 position, float? rotationY = null);

    /// <summary>
    /// Returns bool / int / float / string
    /// Retrieves the value of the given general tab setting. Dropdown setting's values are ordered 0,n.
    ///Example: GetGeneralSetting("Difficulty") returns 0 for training, 1 for easy, 2 for normal, and 3 for hard.
    /// </summary>
    /// <param name="setting"></param>
    /// <returns></returns>
    function<object> GetGeneralSetting(string setting);

    /// <summary>
    /// Retrieves the value of the given titan tab setting.
    /// </summary>
    /// <param name="setting"></param>
    /// <returns></returns>
    function<object> GetTitanSetting(string setting);

    /// <summary>
    /// Retrieves the value of the given misc tab setting. Dropdown setting's values are ordered 0,n.
    ///Example: GetMiscSetting("PVP")
    ///returns results ordered 0,n in order of the dropdown list of the setting.
    ///0 for off, 1 for ffa, and 2 for teams.
    /// </summary>
    /// <param name="setting"></param>
    /// <returns></returns>
    function<object> GetMiscSetting(string setting);

    /// <summary>
    /// Spawns a projectile. Valid projectiles: ThunderSpear, CannonBall, Flare, BladeThrow, Smokebomb, Rock1. ThunderSpear takes two extra params (radius: float, color: Color)
    ///Flare takes extra param (color: Color).
    /// </summary>
    /// <param name="projectileType"></param>
    /// <param name="position"></param>
    /// <param name="rotation"></param>
    /// <param name="velocity"></param>
    /// <param name="gravity"></param>
    /// <param name="liveTime"></param>
    /// <param name="team"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    function SpawnProjectile(string projectileType, Vector3 position, Vector3 rotation, Vector3? velocity,
        Vector3 gravity, float liveTime, string team, params object[] parameters);

    /// <summary>
    /// Spawns a projectile from the given character as its owner.
    /// </summary>
    /// <param name="projectileType"></param>
    /// <param name="position"></param>
    /// <param name="rotation"></param>
    /// <param name="velocity"></param>
    /// <param name="gravity"></param>
    /// <param name="liveTime"></param>
    /// <param name="team"></param>
    /// <param name="owner"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    function SpawnProjectileWithOwner(string projectileType, Vector3 position, Vector3 rotation, Vector3? velocity,
        Vector3 gravity, float liveTime, string team, Character owner, params object[] parameters);

    /// <summary>
    /// Spawns an effect. Valid effects can be found here (left-hand variable name). ThunderSpearExplode takes extra params explodeColor (Color) and killSound (bool).
    /// https://raw.githubusercontent.com/AoTTG-2/Aottg2-Unity/refs/heads/main/Assets/Scripts/Effects/EffectPrefabs.cs
    /// </summary>
    /// <param name="effect"></param>
    /// <param name="position"></param>
    /// <param name="rotation"></param>
    /// <param name="scale"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    function SpawnEffect(string effect, Vector3 position, Vector3 rotation, float scale, params object[] parameters);

    /// <summary>
    /// Sets the music playlist. Valid playlists: Default, Boss, Menu, Peaceful, Battle, Racing
    /// </summary>
    /// <param name="playlistName"></param>
    /// <returns></returns>
    function SetPlaylist(string playlistName);

    /// <summary>
    /// Sets the music song.
    /// </summary>
    /// <param name="songName"></param>
    /// <returns></returns>
    function SetSong(string songName);

    /// <summary>
    /// Returns character from View ID.
    /// </summary>
    /// <param name="viewID"></param>
    /// <returns></returns>
    function<Character> FindCharacterByViewID(int viewID);

    /// <summary>
    /// Locally shows a kill score popup for the player.
    /// </summary>
    /// <param name="score"></param>
    /// <returns></returns>
    function ShowKillScore(int score);

    /// <summary>
    /// Locally shows a kill feed for the player. Valid weapon icons: Blades, AHSS, APG, Thunderspear, Titan, Shifter.
    /// </summary>
    /// <param name="killer"></param>
    /// <param name="victim"></param>
    /// <param name="score"></param>
    /// <param name="weapon"></param>
    /// <returns></returns>
    function ShowKillFeed(string killer, string victim, int score, string weapon);

    /// <summary>
    /// Shows a kill feed for all players. Can be called by anyone.
    /// </summary>
    /// <param name="killer"></param>
    /// <param name="victim"></param>
    /// <param name="score"></param>
    /// <param name="weapon"></param>
    /// <returns></returns>
    function ShowKillFeedAll(string killer, string victim, int score, string weapon);

    #endregion
}