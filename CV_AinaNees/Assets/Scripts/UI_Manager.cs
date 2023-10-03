using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;

    public List<GameObject> windows_List;

    public Item_list_Tabs itemListtabs;
    public GameObject content_list_tabs;

    public void Awake()
    {
        instance = this;
    }

    private void CloseAllWindows()
    {
        foreach (var tab in windows_List)
        {
            tab.SetActive(false);
        }
    }

    public void OpenWindow(string name_window)
    {
        foreach (var window in windows_List)
        {
            if (window.name.Equals(name_window))
            {
                window.transform.position = new Vector2(980,540);
                window.SetActive(true);
                CloseTab(name_window);
            }
        }
    }
    
    public void CloseWindow(string name_window)
    {
        foreach (var window in windows_List)
        {
            if (window.name.Equals(name_window))
            {
                window.SetActive(false);
                CloseTab(name_window);
            }
        }
    }
    
    public void MinimizeWindow(string name_window)
    {
        foreach (var window in windows_List)
        {
            if (window.name.Equals(name_window))
            {
                window.SetActive(false);
                CreateTab(window.name,window.transform.GetChild(0).GetComponent<Image>().sprite);
            }
        }
    }

    private void CreateTab(string name_tab, Sprite icon_tab)
    {
        Item_list_Tabs  _itemListtabs;
        _itemListtabs = Instantiate(itemListtabs, content_list_tabs.transform);
        _itemListtabs.name = name_tab;
        _itemListtabs.icon_window = icon_tab;
    }

    public void CloseTab(string name_sprite)
    {
        foreach (Transform child in content_list_tabs.transform)
        {
            if (child.name.Equals(name_sprite))
            {
                Destroy(child.gameObject);
            }
        } 
    }
    
    public void OpenLinkLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/aina-nees-604643211/");
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/aneescolo");
    }
    
    public void OpenGitHub_Grabadora()
    {
        Application.OpenURL("https://github.com/aneescolo/Gravadora_Panasonic.git");
    }
    
    public void OpenGitHub_Pivihex()
    {
        Application.OpenURL("https://github.com/Aarchyy89/Projecte_Final.git");
    }
    
    public void OpenGitHub_Planetes()
    {
        Application.OpenURL("https://github.com/aneescolo/SpaceOdyssey.git");
    }
    
    public void OpenGitHub_Filtres()
    {
        Application.OpenURL("https://github.com/Aarchyy89/Projecte_Final.git");
    }
    
    public void OpenGitHub_Ikea()
    {
        Application.OpenURL("https://github.com/Aarchyy89/Projecte_Final.git");
    }
    
    public void OpenGitHub_SpellCaster()
    {
        Application.OpenURL("https://github.com/guiler126/Proyecto_AR_final.git");
    }
}
