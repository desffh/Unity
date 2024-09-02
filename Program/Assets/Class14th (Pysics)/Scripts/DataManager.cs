using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;

    void Awake()
    {
        Load();
    }

    public void Save()
    {
        PlayerPrefs.Save(); // ��ü ����
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score", score); // �ҷ�����
    }

    public void Increase()
    {
        score += 10;
        PlayerPrefs.SetInt("Score", score); // score�� ����
    }

    public void Initialized()
    {
        PlayerPrefs.DeleteAll(); // ������ ��� ����

        Load(); // ������ ��� �����ϰ� �ҷ�����(���� �ʱ�ȭ�� ����)

    }
}
