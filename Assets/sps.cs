using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public int points = 10; // Количество очков за сбор предмета

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, столкнулся ли объект с персонажем
        if (other.CompareTag("Player"))
        {
            // Выполняем действие при сборе предмета
            Debug.Log($"Вы собрали {points} очков");
            
            // Здесь можно добавить обработку изменения счётчика очков,
            // например: ScoreManager.AddScore(points); 
            
            // Удаляем объект после сбора
            Destroy(this.gameObject);
        }
    }
}
