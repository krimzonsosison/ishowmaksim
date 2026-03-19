using UnityEngine;

public class ShowMenuAfterDelay : MonoBehaviour
{
    public GameObject menuPanel;  // Панель меню, назначьте в инспекторе

    public float delay = 10f;     // Задержка в секундах

    void Start()
    {
        // Скрываем меню сразу на старте
        if (menuPanel != null) menuPanel.SetActive(false);

        // Запускаем корутину ожидания
        StartCoroutine(ShowMenuWithDelay());
    }

    System.Collections.IEnumerator ShowMenuWithDelay()
    {
        yield return new WaitForSeconds(delay);

        if (menuPanel != null)
            menuPanel.SetActive(true);
    }
}