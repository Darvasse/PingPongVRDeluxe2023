using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 2f;

    public bool isMoving = true;

    public Vector3 direction = new Vector3(0, 1, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position += direction * speed * Time.deltaTime;
        speed = speed + 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            gameObject.transform.position += direction * speed * Time.deltaTime;
            speed = speed + 0.2f;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            isMoving = false;
        }
    }
}
