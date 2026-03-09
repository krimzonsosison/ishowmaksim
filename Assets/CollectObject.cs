using UnityEngine;

public class CollectOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверка, что столкновение с нужным объектом
        if (collision.gameObject.CompareTag("Collectible"))
        {
            // Можно добавить логику сбора, например, увеличить счет
            Debug.Log("Объект собран: " + collision.gameObject.name);
            // Удаляем объект
            Destroy(collision.gameObject);
        }
    }
}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
  