using AoTTG2_Custom_Logic.MapObjects;

namespace AoTTG2_Custom_Logic;

public interface IMap
{
    /// <summary>
    /// Returns all map objects in the game.
    /// </summary>
    /// <returns></returns>
    function<List<MapObject>> FindAllMapObjects();

    /// <summary>
    /// Returns the first map object matching the given name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    function<MapObject> FindMapObjectByName(string name);

    /// <summary>
    /// Returns a list of map objects matching the given name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    function<List<MapObject>> FindMapObjectsByName(string name);

    /// <summary>
    /// Returns the map object matching ID.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    function<MapObject> FindMapObjectByID(int id);

    /// <summary>
    /// Returns the first map object that has a tag component matching the given name
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    function<MapObject> FindMapObjectByTag(string tag);

    /// <summary>
    /// Returns a list of map objects matching the given tag
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    function<List<MapObject>> FindMapObjectsByTag(string tag);

    /// <summary>
    /// Returns a list of map objects which have the corresponding CL component attached
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    function<List<MapObject>> FindMapObjectsByComponent(string tag);

    /// <summary>
    /// Creates a map object given the raw data string, which corresponds to a map file CSV row
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    function<MapObject> CreateMapObjectRaw(string data);

    /// <summary>
    /// Destroys the given map object, and its children if includeChildren is true.
    /// </summary>
    /// <param name="mapObject"></param>
    /// <param name="includeChildren"></param>
    /// <returns></returns>
    function DestroyMapObject(object mapObject, bool includeChildren);

    /// <summary>
    /// Creates a copy of the given map object, and its children if includeChildren is true.
    /// </summary>
    /// <param name="mapObject"></param>
    /// <param name="includeChildren"></param>
    /// <returns></returns>
    function<MapObject> CopyMapObject(object mapObject, bool includeChildren);

    /// <summary>
    /// Destroys the given map targetable (see MapObject on creating AI targets).
    /// </summary>
    /// <param name="mapTargetable"></param>
    /// <returns></returns>
    function DestroyMapTargetable(object mapTargetable);

    /// <summary>
    /// Updates the Navmesh (host only). This operation may take a while depending on the map size. If you have a bad computer, please use UpdateNavMeshAsync to avoid disconnecting due to the non-async method hanging. (honestly I have no idea why you would want to use this but whatever)
    /// </summary>
    /// <returns></returns>
    function UpdateNavMesh();

    /// <summary>
    /// Updates the Navmesh (host only) asynchronously and (hopefully) should not hang. This process is still somewhat CPU intensive so maybe pause the game or add in a loading screen when using this. For realtime dynamic changes to the map, please use the NavMeshObstacle Component.
    /// </summary>
    /// <returns></returns>
    function UpdateNavMeshAsync();
}