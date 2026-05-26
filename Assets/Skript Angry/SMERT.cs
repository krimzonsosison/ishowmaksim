using UnityEngine;

public class DestroyOnFall : MonoBehaviour
{
    // Установите минимальную высоту, ниже которой объект будет уничтожаться
    public float fallThreshold = -5f;
    public starmanager starman;

    void Update()
    {
        // Проверяем, если объект ниже пороговой высоты
        if (transform.position.y < fallThreshold)
        {
            Destroy(gameObject); // Уничтожаем объект
            starman.destroyedObjectsCount++;
        }
    }
}