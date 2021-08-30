using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // public GameObject это класс или тип с именем dogPrefab и он виден в инспекторе.
    // помещаем префаб собаки в GameObject dogPrefab (В инспекторе Player).
    public GameObject dogPrefab;
    // Периодичность с которой игрок может выпускать собаку.
    private float fireRate = 0.5f;
    // следующий выпуск собаки после предыдущего можно будет делать начиная с 0 секунды.
    private float nextFire = 0;

    void Update()
    {
        // Если нажимаем пробел и Time.time > 0
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            // сбрасываем следующий выпуск собаки по времени до 0 + 0,5 т.е. собаку можно выпускать с периодичностью 0,5 секунд.
            nextFire = Time.time + fireRate;
            // Instantiate(dogPrefab создаем копии существующего dogPrefab.
            // transform.position нужен для того чтобы клоны собак появлялись в нужной позиции у Player.
            // dogPrefab.transform.rotation поворот собаки остается по умолчанию, так как двигается только в одну сторону.
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
