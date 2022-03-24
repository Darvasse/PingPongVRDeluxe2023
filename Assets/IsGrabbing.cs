using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrabbing : MonoBehaviour
{
    public GameObject cannon;
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
        if (test)
        {
            GrabBat();
        }
        else
        {
            UnGrabBat();
        }
    }
}
