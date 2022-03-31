using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score_Display : MonoBehaviour
{
    public TMP_Text test;
    public static Score_Display instance;
    public bool isSoloGame;
    public int latest_SoloScore=0,latestDuoScore=0;
    private Solo_Game GameMode;
    private Rebound_Count ReboundCounter;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        test.alignment = TextAlignmentOptions.Center;
        ReboundCounter = FindObjectOfType<Rebound_Count>();
        if ((int)Scene_Manager.instance.getCurrentSceneID() == 2)
        {
            isSoloGame = true;
            test.text = "Score\n" + latest_SoloScore.ToString();
            Solo_Game.instance.isSoloGame = true;
        }
        else
        {
            isSoloGame = false;
            Solo_Game.instance.isSoloGame = false;
        }
    }

    public void UpdateScoreboard()
    {
        if (isSoloGame)
        {
            latest_SoloScore = Solo_Game.instance.Solo_Score;
            test.text = "Score :\n" + latest_SoloScore;
        }
        else
        {
            latest_SoloScore = Solo_Game.instance.Solo_Score;
            latestDuoScore = Solo_Game.instance.Duo_Score;
            test.text = "Score :\n" + latest_SoloScore+" : "+latestDuoScore;
        }
        
    }
}
