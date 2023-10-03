using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_list_Tabs : MonoBehaviour
{
    public Sprite icon_window;

    void Start()
    {
        transform.GetChild(0).GetComponent<Image>().sprite = icon_window;
        transform.GetChild(1).GetComponent<TMP_Text>().text = name;
        
        var button = GetComponent<Button>();
        button.onClick.AddListener(delegate { UI_Manager.instance.OpenWindow(name);});
    }
}
