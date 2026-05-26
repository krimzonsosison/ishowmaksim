using UnityEngine;
using UnityEngine.UI;

public class StarChecker : MonoBehaviour
{
    public int stars; // Переменная для хранения количества звезд
    public Text resultText; // Текст для отображения результата

    public void CheckStars()
    {
        if (stars > 1)
        {
            resultText.text = "Молодец!";
        }
        else if (stars == 0)
        {
            resultText.text = "Плохо!";
        }
      
    }
}