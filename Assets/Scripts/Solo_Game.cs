using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solo_Game : MonoBehaviour
{
    public int Solo_Score { get; private set; } = 0;
    public int Duo_Score { get; private set; } = 0;
    public static Solo_Game instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    
    public void Adding_Point(int pointWinner) 
    {
        if(pointWinner == 1)
        {
            Solo_Score += 1;
        }
        else
        {
            Duo_Score += 1;
        }
        Score_Display.instance.UpdateScoreboard();
    }
    public void NewGame()
    {
        FindObjectOfType<LeaderBoard>().SaveScore(name, Solo_Score >= Duo_Score ? Solo_Score : Duo_Score);
        Solo_Score = 0;
        Duo_Score = 0;
        Score_Display.instance.UpdateScoreboard();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        
    }

}
