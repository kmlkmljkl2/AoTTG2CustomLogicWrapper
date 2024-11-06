namespace AoTTG2_Custom_Logic;

public interface IUi
{
    /// <summary>
    /// Sets the label at a certain location. Valid types: "TopCenter", "TopLeft", "TopRight", "MiddleCenter", "MiddleLeft", "MiddleRight", "BottomLeft", "BottomRight", "BottomCenter".
    /// </summary>
    /// <param name="type"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    function SetLabel(string type, string label);
    /// <summary>
    /// Sets the label for a certain time, after which it will be cleared.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="label"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    function SetLabelForTime(string type, string label, float time);
    /// <summary>
    /// Sets the label for all players. Master client only. Be careful not to call this often.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    function SetLabelAll(string type, string label);
    /// <summary>
    /// Sets the label for all players for a certain time. Master client only.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="label"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    function SetLabelForTimeAll(string type, string label, float time);
    /// <summary>
    /// Creates a new popup. This popup is hidden until shown.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="title"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    function CreatePopup(string name, string title, int width, int height);
    /// <summary>
    /// Shows the popup with given name.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    function ShowPopup(string name);
    /// <summary>
    /// Hides the popup with given name.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    function HidePopup(string name);
    /// <summary>
    /// Clears all elements in popup with given name.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    function ClearPopup(string name);
    /// <summary>
    /// Adds a text row to the popup with label as content.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="label"></param>
    /// <returns></returns>
    function AddPopupLabel(string name, string label);
    /// <summary>
    /// Adds a button row to the popup with given button name and display text. When button is pressed, OnButtonClick is called in Main with buttonName parameter.
    /// </summary>
    /// <param name="popupName"></param>
    /// <param name="buttonName"></param>
    /// <param name="buttonText"></param>
    /// <returns></returns>
    function AddPopupButton(string popupName, string buttonName, string buttonText);
    /// <summary>
    /// Adds a list of buttons in a row to the popup.
    /// </summary>
    /// <param name="popupName"></param>
    /// <param name="buttonNames"></param>
    /// <param name="buttonTitles"></param>
    /// <returns></returns>
    function AddPopupButtons(string popupName, List<string> buttonNames, List<string> buttonTitles);
    /// <summary>
    /// Adds a button to the bottom bar of the popup.
    /// </summary>
    /// <param name="popupName"></param>
    /// <param name="buttonName"></param>
    /// <param name="buttonText"></param>
    /// <returns></returns>
    function AddPopupBottomButton(string popupName, string buttonName, string buttonText);
    /// <summary>
    /// Returns a wrapped string given style and args.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="style"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    function<string> WrapStyleTag(string text, string style, string args);
    /// <summary>
    /// Gets translated locale from the current Language.json file with given category, subcategory, and key pattern.
    /// </summary>
    /// <param name="category"></param>
    /// <param name="subcategory"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    function<string> GetLocale(string category, string subcategory, string key);
    /// <summary>
    /// Returns the current language (ie "English).
    /// </summary>
    /// <returns></returns>
    function<string> GetLanguage();
    /// <summary>
    /// Shows the change character menu if main character is Human.
    /// </summary>
    /// <returns></returns>
    function ShowChangeCharacterMenu();
    /// <summary>
    /// Sets the display of the scoreboard header (default "Kills / Deaths...")
    /// </summary>
    /// <param name="header"></param>
    /// <returns></returns>
    function SetScoreboardHeader(string header);
    /// <summary>
    /// Sets which Player custom property to read from to display on the scoreboard. If set to empty string, will use the default "Kills / Deaths..." display.
    /// </summary>
    /// <param name="property"></param>
    /// <returns></returns>
    function SetScoreboardProperty(string property);

}