using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Runtime.CompilerServices;

public class starmanager : MonoBehaviour
{
    public int totalObjectsToDestroy = 3; // Максимальное число объектов
    public int destroyedObjectsCount = 0;
    public AudioSource musicSource;

    public GameObject star;
    public GameObject star2;
    public GameObject star3;
    public string levelName = "lvl1";
   
   

    public string stars;
    public string savedstars;

    public float delayBeforeShowStars = 10f; // Время ожидания перед показом звезд

    private void Start()
    {
        // Изначально скрываем все звезды
        star.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }

    public void ObjectDestroyed()
    {
        destroyedObjectsCount++;
        if (destroyedObjectsCount >= totalObjectsToDestroy)
        {
            
            
        }
    }

    private IEnumerator ShowStarsAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeShowStars);
        star.transform.parent.gameObject.SetActive(true);
       
        if (destroyedObjectsCount == 1)
        {
            star.SetActive(true);
        }
        else if (destroyedObjectsCount == 2)
        {
            star.SetActive(true);
            star2.SetActive(true);
        }
        else if (destroyedObjectsCount >= 3)
        {
            star.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            
            if (musicSource != null)
    
        musicSource.Play();
        }
        
        
       

        // Получить сохраненные звезды

        // Если текущее значение больше, чем сохраненное - сохранить



        int savedstars = PlayerPrefs.GetInt(levelName,0);
           
           if (destroyedObjectsCount > savedstars)
        {
            PlayerPrefs.SetInt(levelName,destroyedObjectsCount);
            PlayerPrefs.Save(); 
        }
        
       




     }
     
    
    

        
        
        
 
    public void ShowStars()
    {
        StartCoroutine("ShowStarsAfterDelay");
    }
}