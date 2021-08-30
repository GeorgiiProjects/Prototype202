using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    // переменная для скорости передвижения мяча настраивается в инспекторе.
    public float speed;

    void Update()
    {
        // Создаем направление и скорость движения мяча в секундах на любом пк.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
