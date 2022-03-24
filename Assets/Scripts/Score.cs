using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : ScriptableObject
{
    public string PlayerName;
    public int highScore;
    public Score(string player,int score) { highScore = score;PlayerName = player; }
}
