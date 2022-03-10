using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobelet_Hit : MonoBehaviour
{
    private Transform BallPos;
    private GameObject Ball;

    void Start()
    {
        Ball = GameObject.Find("Ball");
        BallPos = Ball.GetComponent<Transform>(); 
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Ball")
        {
            BallPos.position = new Vector3(6.338f,1.024f,2.904f);
            Destroy(gameObject);
        }
    }
}
