using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] string [] buttonNames;

    [SerializeField] Text[] buttonTexts;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = buttonNames[i];
        }
    }

    public void NewGame()
    {
        Debug.Log("New Game");
    }
    public void Continue()
    {
        Debug.Log("Continue");
    }
    public void Exit()
    {
        Debug.Log("Exit");
    }

}
