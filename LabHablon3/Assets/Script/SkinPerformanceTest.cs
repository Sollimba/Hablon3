using UnityEngine;
using System.Diagnostics; // �� �������� ���������� ������������ ���� System.Diagnostics ��� ������������� Stopwatch

public class SkinPerformanceTest : MonoBehaviour
{
    public GameObject characterPrefab; // ������ ���������
    public int characterCount = 10000; // ���������� ���������� ��� �����
    private SkinManager skinManager;

    void Start()
    {
        // ������� ������ SkinManager
        GameObject skinManagerObject = new GameObject("SkinManager");
        skinManager = skinManagerObject.AddComponent<SkinManager>();

        // ������� ������ ��� �������� ������ �� ��������� �������
        GameObject[] characters = new GameObject[characterCount];

        // ������� ���������� � ��������� �� � ������
        for (int i = 0; i < characterCount; i++)
        {
            characters[i] = Instantiate(characterPrefab, new Vector3(i * 1.5f, 0, 0), Quaternion.identity);
        }

        // ������� � ��������� Stopwatch
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // ��������� ���� �� ���� ����������
        for (int i = 0; i < characterCount; i++)
        {
            skinManager.ApplySkinToCharacter("Skin1", characters[i]);
        }

        // ������������� Stopwatch � ������� ���������
        stopwatch.Stop();
        UnityEngine.Debug.Log("Time taken to apply skin to 1000 characters: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
