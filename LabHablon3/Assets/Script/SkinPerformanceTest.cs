using UnityEngine;
using System.Diagnostics; // Не забудьте подключить пространство имен System.Diagnostics для использования Stopwatch

public class SkinPerformanceTest : MonoBehaviour
{
    public GameObject characterPrefab; // Префаб персонажа
    public int characterCount = 10000; // Количество персонажей для теста
    private SkinManager skinManager;

    void Start()
    {
        // Создаем объект SkinManager
        GameObject skinManagerObject = new GameObject("SkinManager");
        skinManager = skinManagerObject.AddComponent<SkinManager>();

        // Создаем массив для хранения ссылок на созданные объекты
        GameObject[] characters = new GameObject[characterCount];

        // Создаем персонажей и добавляем их в массив
        for (int i = 0; i < characterCount; i++)
        {
            characters[i] = Instantiate(characterPrefab, new Vector3(i * 1.5f, 0, 0), Quaternion.identity);
        }

        // Создаем и запускаем Stopwatch
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // Применяем скин ко всем персонажам
        for (int i = 0; i < characterCount; i++)
        {
            skinManager.ApplySkinToCharacter("Skin1", characters[i]);
        }

        // Останавливаем Stopwatch и выводим результат
        stopwatch.Stop();
        UnityEngine.Debug.Log("Time taken to apply skin to 1000 characters: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
