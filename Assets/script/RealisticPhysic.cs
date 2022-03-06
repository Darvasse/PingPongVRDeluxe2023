using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealisticPhysic : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    private Vector3 lastFrameVelocity;

    [SerializeField]
    public float minVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        lastFrameVelocity = rb.velocity;
        minVelocity = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collision.contacts[0].normal);
        GetComponent<Rigidbody>().velocity = direction * (Mathf.Max(speed, minVelocity) / 4) * 3;
    }
}
