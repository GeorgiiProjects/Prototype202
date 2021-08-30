using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // метод позволяет взаимодействовать коллайдерам собаки и мячей друг с другом
    private void OnTriggerEnter(Collider other)
    {
        // при взаимодействии уничтожается мяч.
        Destroy(gameObject);
    }
}
