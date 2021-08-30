using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // Создаем массив, который виден в инспекторе для того, чтобы заполнить его префабами мячей.
    public GameObject[] ballPrefabs;
    // Спавн мячей по оси -x
    private float spawnLimitXLeft = -22;
    // Спавн мячей по оси x
    private float spawnLimitXRight = 7;
    // Спавн мячей по оси y
    private float spawnPosY = 30;
    // задержка появления мяча
    private float startDelay = 2.0f;
    
    void Start()
    {
        // создаем метод Invoke, для того, чтобы мячи спавнились автоматически при старте игры.
        // вызываем метод SpawnRandomBall, так как именно его используем для случайного спавна мячей, стартовая задержка 2 секунды.
        Invoke("SpawnRandomBall", startDelay);
    }

    // Метод для случайного появления мяча в случайное время.
    void SpawnRandomBall ()
    {
        // создаем переменную ballIndex, в этом методе, так как только тут будем ее использовать. 
        // используем класс Random.Range для того, чтобы мячи спавнились со случайностью от 0 до длины массива мячей т.е. 3.
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Используем Random.Range, чтобы мячи спавнились в разных точках от -22 до 7 по оси x.
        // Используем Vector3 spawnPos для того, чтобы занести в формулу координаты спавна мячей.
        // Спавн мячей по осям y и z остаются неизменными, по оси y задано значение 30
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // Создаем копии ballPrefabs по номеру индекса массива, поворот мячей остается по умолчанию, так как двигаются только в одну сторону.
        // Используем spawnPos в которой занесены кординаты спауна мячей по осям x,y,z.
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        // Задержка появления мячей происходит случайным образом от 0 до 10 секунд.
        startDelay = Random.Range(0, 10);
        // мячи спавнятся автоматически во время игры с задержкой от 0 до 10 секунд.
        Invoke("SpawnRandomBall", startDelay);
    }
}
