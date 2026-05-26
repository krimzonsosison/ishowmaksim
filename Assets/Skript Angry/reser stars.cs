using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StarProgressManager : MonoBehaviour
{
   public void DeleteAllPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Debug.Log("Все PlayerPrefs удалены!");
    }
}
