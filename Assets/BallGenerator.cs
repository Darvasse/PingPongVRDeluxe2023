using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject BallPrefab,CurrentBall;
    // Start is called before the first frame update
    void Start()
    {
        CurrentBall = Instantiate(BallPrefab);
        Vector3 pos = new Vector3(-0.21f, 0.68f, 1.31f);
        CurrentBall.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetBall()
    {
        Destroy(CurrentBall);
        CurrentBall = Instantiate(BallPrefab);
        Vector3 pos = new Vector3(-0.21f, 0.68f, 1.31f);
        CurrentBall.transform.position = pos;
    }
}
