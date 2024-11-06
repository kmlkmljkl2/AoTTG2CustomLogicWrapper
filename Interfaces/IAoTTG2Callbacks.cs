namespace AoTTG2_Custom_Logic;

interface IAoTTG2Callbacks
{
    function OnGameStart();
    function OnCharacterSpawn();
    function OnPlayerSpawn(player, character);

}