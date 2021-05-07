using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ManUpCustomKey : MonoBehaviour
{
    public string key = "customKey";

    public void LoadFromManUp()
    {
        var manUpText = NextFaze.ManUp.Instance.SettingForKey(key)?.Value;
        GetComponent<Text>().text = manUpText ?? "[KEY NOT FOUND]";
    }
}
