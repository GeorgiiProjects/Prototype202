using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    // приватная переменная создана для создания левого предела уничтожения собаки.
    private float leftLimit = -30;
    // приватная переменная создана для создания нижнего предела уничтожения мячей.
    private float bottomLimit = -5;

    void Update()
    {
        // Если позиция по оси x < leftLimit
        if (transform.position.x < leftLimit)
        {
            // уничтожаем собаку
            Destroy(gameObject);
        }
        // Если позиция по оси y < bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            // уничтожаем мяч
            Destroy(gameObject);
        }

    }
}
