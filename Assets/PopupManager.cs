using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    public GameObject popupWindow; // влажходящая панель
    public Image starImage;        // изображение звезды
    public Text messageText;  
    
    public int starCount = 1;
   



    public void ShowStarPopup(string message)
    {
        popupWindow.SetActive(true);
        starImage.gameObject.SetActive(true);
        messageText.text = message;
    }

    public void HidePopup()
    {
        popupWindow.SetActive(false);
        starImage.gameObject.SetActive(false);
    }
}