using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score_Display : MonoBehaviour
{
    public TMP_Text test;
    public bool isSoloGame;
    public int latest_SoloScore=0,latestDuoScore=0;
    private Solo_Game GameMode;
    // Start is called before the first frame update
    void Start()
    {
        test.alignment = TextAlignmentOptions.Center;
        GameMode = FindObjectOfType<Solo_Game>();
        if ((int)Scene_Manager.instance.getCurrentSceneID() == 2)
        {
            isSoloGame = true;
            test.text = "Score\n"+ latest_SoloScore.ToString();
        }
        else
        {
            isSoloGame = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isSoloGame)
        {
            latest_SoloScore = GameMode.Solo_Score;
        }
        else
        {
            latest_SoloScore = GameMode.Solo_Score;
            latestDuoScore = GameMode.Duo_Score;
        }
    }
}
