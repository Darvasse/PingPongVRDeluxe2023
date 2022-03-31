using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound_Count : MonoBehaviour
{
    public int rebound_Counter { get; private set; } = 0;
    // Start is called before the first frame update
    public GameObject last_hitter = null;
    public GameObject BallPrefab;
    public bool table_Hitted = false;
    void Start()
    {
        Debug.Log(rebound_Counter);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Racket")
        {
            last_hitter = collision.gameObject;
            table_Hitted = false;
        }
        if (collision.gameObject.tag == "Ground")
        {

            int winner;
            if (last_hitter != null)
            {
                if ((last_hitter.name == "Joueur1" && table_Hitted) || (last_hitter.name == "Joueur2" && !table_Hitted))
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }
            //Solo_Game.instance.Adding_Point(winner);
            if (Scene_Manager.instance.getCurrentSceneID() == SceneID.SceneDesert)
            {
                FindObjectOfType<BallGenerator>().ResetBall();
            }
            Solo_Game.instance.NewGame();
        }
        if (collision.gameObject.tag == "Table")
        {
            table_Hitted = true;
        }
        if (collision.gameObject.tag == "Wall" && table_Hitted == true)
        {
            Solo_Game.instance.Adding_Point(1);
            StartCoroutine(ResetTableHit());
        }
        if (collision.gameObject.tag == "Wall" && table_Hitted == false)
        {
            Solo_Game.instance.NewGame();
        }
    }
    IEnumerator ResetTableHit()
    {
        yield return new WaitForSeconds(0.15f);
        table_Hitted = false;
    }
}