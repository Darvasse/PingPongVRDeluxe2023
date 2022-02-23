using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        Vector3 newAngle=  -ProcessAngle();
        collider.gameObject.GetComponent<Rigidbody>().MovePosition();
    }
    public Vector3 ProcessAngle()
    {
        Vector3 res;
        Vector3 vel = gameObject.GetComponent<Rigidbody>().velocity;
        return res;
    }
    public Vector3 ProcessNewSpeed()
    {
        Vector3 res= gameObject.GetComponent<Rigidbody>().velocity;
        res = res * 0.9f;
        return res;
    }
}
