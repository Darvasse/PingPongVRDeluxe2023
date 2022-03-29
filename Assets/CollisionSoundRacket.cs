using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSoundRacket : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
