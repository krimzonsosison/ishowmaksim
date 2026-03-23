using UnityEngine;

public class LevelsStars : MonoBehaviour
{
    public GameObject star;
    public GameObject star2;
    public GameObject star3;
  public int stars; 
   public void SaveStars()
    {
        PlayerPrefs.SetInt("angry", stars);
        PlayerPrefs.Save();
        }   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         stars = PlayerPrefs.GetInt("StarsKey", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
