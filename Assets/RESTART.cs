using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Метод для перезапуска уровня
    public void RestartLevel()
    {
        // Получаем текущую сцену и перезагружаем её
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}