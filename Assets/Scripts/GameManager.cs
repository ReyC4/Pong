using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int ScoreKnight;
    public int ScoreGoblin;
    public TMP_Text uiScoreKnight;
    public TMP_Text uiScoreGoblin;
    public TMP_Text uiWinTextCont;
    public GameObject uiWinLose;

    public static GameManager instance;
    public SceneManagement sceneManagement;
    public void Awake()
    {
        if(instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void Score(string sideWallName)
    {
        if(sideWallName == "SideWallKnight") 
        {
            ScoreGoblin += 1;
            uiScoreGoblin.text = ScoreGoblin.ToString();
            ScoreCheck();
        }
        
        else 
        {
            ScoreKnight += 1;
            uiScoreKnight.text = ScoreKnight.ToString();
            ScoreCheck();
        }
    }

    private void Delay()
    {
        sceneManagement.ChangeScene("Menu");
    }

    private void ScoreCheck()
    {
        if(ScoreKnight == 10)
        {
            uiWinLose.SetActive(true);
            uiWinTextCont.text = "Knight Win!";
            Invoke("Delay", 2.0f);
        } 
        else if(ScoreGoblin == 10)
        {
            uiWinLose.SetActive(true);
            uiWinTextCont.text = "Goblin Win!";
            Invoke("Delay", 2.0f);
        } 
    }
}
