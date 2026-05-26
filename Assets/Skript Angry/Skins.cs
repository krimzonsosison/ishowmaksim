using NUnit.Framework;
using UnityEngine;

public class Skins : MonoBehaviour
{
    public SpriteRenderer igrok;
    public GameObject PanelChange;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void ChangeSkin1()
    {
        PlayerPrefs.SetInt("skins",1);
        PlayerPrefs.Save();
        
    }
    public void ChangeSkin2()
    {  PlayerPrefs.SetInt("skins",2);
    PlayerPrefs.Save();
    }
    public void ChangeSkin3()
    {  PlayerPrefs.SetInt("skins",3);
    PlayerPrefs.Save();
    }
    
  

    // Update is called once per frame
}
