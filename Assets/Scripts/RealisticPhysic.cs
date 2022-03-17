using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealisticPhysic : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private Vector3 currentFrameVelocity;

    [SerializeField]
    public float minVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        currentFrameVelocity = rb.velocity;
        minVelocity = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = currentFrameVelocity.magnitude;
        var direction = Vector3.Reflect(currentFrameVelocity.normalized, collision.contacts[0].normal);
        if (collision.gameObject.tag == "Racket")
        {
            float racketForce = collision.gameObject.GetComponent<Racket_Force>().getForce();
            if (racketForce > 0)
            {
                GetComponent<Rigidbody>().velocity = direction * (Mathf.Max(speed, minVelocity) / 30) * racketForce;
            }
            else
            {
                GetComponent<Rigidbody>().velocity = direction * (Mathf.Max(speed, minVelocity) / 4) * 3;
            }
        }
        else
        {
            GetComponent<Rigidbody>().velocity = direction * (Mathf.Max(speed, minVelocity) / 4) * 3;
        }
    }
}
