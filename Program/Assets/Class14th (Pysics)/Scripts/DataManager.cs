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
        PlayerPrefs.Save(); // 전체 저장
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score", score); // 불러오기
    }

    public void Increase()
    {
        score += 10;
        PlayerPrefs.SetInt("Score", score); // score값 저장
    }

    public void Initialized()
    {
        PlayerPrefs.DeleteAll(); // 데이터 모두 삭제

        Load(); // 데이터 모두 삭제하고 불러오기(완전 초기화된 상태)

    }
}
