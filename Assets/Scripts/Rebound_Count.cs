using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound_Count : MonoBehaviour
{
    public int rebound_Counter { get; private set; } = 0;
    // Start is called before the first frame update
    public GameObject last_hitter;
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
        if(collision.gameObject.tag == "Player")
        {
            last_hitter = collision.gameObject;
            table_Hitted = false;
        }
        else if (collision.gameObject.tag == "Ground")
        {
            int winner;
            if((last_hitter.name == "Joueur1"&&table_Hitted)||(last_hitter.name == "Joueur2"&&!table_Hitted))
            {
                winner = 1;
            }
            else
            {
                winner = 2;
            }
            Solo_Game.instance.Adding_Point(winner);
        }else if(collision.gameObject.tag == "Table")
        {
            table_Hitted = true;
        }
    }
}
