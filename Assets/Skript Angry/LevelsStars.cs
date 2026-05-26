using UnityEngine;

public class LevelsStars : MonoBehaviour
{
    public GameObject star;
    public GameObject star2;
    public GameObject star3;
    public string levelName = "lvl1";
   
      
      
  public int stars; 
   public void SaveStars()
    {
        PlayerPrefs.SetInt("angry", stars);
        PlayerPrefs.Save();
        
        }  

        
     
    void Start()
    {
        stars = PlayerPrefs.GetInt(levelName, 0);
        print(stars);
        
         if (stars == 1)
        {
            star.SetActive(true);
        }
        else if (stars == 2)
        {
            star.SetActive(true);
            star2.SetActive(true);
        }
        else if (stars >= 3)
        {
            star.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
       
    {
        


       
    
    }



       
    
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

