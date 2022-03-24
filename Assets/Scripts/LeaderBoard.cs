
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderBoard : MonoBehaviour
{
    public TMP_Text scoreList;
    private void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("TestNull"));
    }
    public void SaveScore(string name, int score)
    {
        string saveFilePath = "Assets/ScoreList/";
        if (PlayerPrefs.GetInt(name) != 0)
        {
            Score test = new Score(name,score);
            PlayerPrefs.SetInt(name, score);
            PlayerPrefs.Save();
        }
        else { Debug.Log("Nom deja utilise ou Score = 0"); }
        
    }
    public void ShowScore()
    {
        
    }
}
