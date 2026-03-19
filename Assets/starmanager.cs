using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class starmanager : MonoBehaviour
{
    public int totalObjectsToDestroy = 3; // Максимальное число объектов
    public int destroyedObjectsCount = 0;

    public GameObject star;
    public GameObject star2;
    public GameObject star3;

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
            // Запускаем через некоторое время отображение звезд
            
        }
    }

    private IEnumerator ShowStarsAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeShowStars);
        star.transform.parent.gameObject.SetActive(true);
        // В зависимости от количества уничтоженных объектов показываем звезды
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
        }
    }

    public void ShowStars()
    {
        StartCoroutine("ShowStarsAfterDelay");
    }
}