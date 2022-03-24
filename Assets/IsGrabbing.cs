using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrabbing : MonoBehaviour
{
    public GameObject cannon;
    public Transform bat;

    public bool test;

    public void GrabBat()
    {
        cannon.GetComponent<CannonShoot>().holdBat = true;
       
    }
    public void UnGrabBat()
    {
        cannon.GetComponent<CannonShoot>().holdBat = false;
    }

    void Update()
    {
        float distance = Vector3.Distance(cannon.GetComponent<Transform>().position, bat.position);
        //Debug.Log(distance);
    }
}
