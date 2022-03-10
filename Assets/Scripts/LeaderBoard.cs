
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("TestNull"));
    }
    public void SaveScore(string name, int Score)
    {
        string saveFilePath = "Assets/ScoreList/";
        if (PlayerPrefs.GetInt(name) != 0)
        {
            PlayerPrefs.SetInt(name, Score);
        }
        else { Debug.Log("Nom deja utilise ou Score = 0"); }
        
    }
}
