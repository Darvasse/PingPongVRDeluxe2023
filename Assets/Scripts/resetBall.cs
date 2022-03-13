using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetBall : MonoBehaviour
{

    private Transform BallPos;
    private GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.Find("Ball");
        BallPos = Ball.GetComponent<Transform>(); 
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ball")
        {
            BallPos.position = new Vector3(6.17f,0.792f,3.036f);
        }
    }


}
