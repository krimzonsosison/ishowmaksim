using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panel; // Панель, которую мы будем открывать и закрывать
    public Button toggleButton; // Кнопка для открытия/закрытия панели

    void Start()
    {
        // Подписываемся на событие нажатия кнопки
        toggleButton.onClick.AddListener(TogglePanel);
        panel.SetActive(false); // Убедитесь, что панель изначально скрыта
    }

    void TogglePanel()
    {
        // Переключаем состояние панели
        panel.SetActive(!panel.activeSelf);
    }
}   