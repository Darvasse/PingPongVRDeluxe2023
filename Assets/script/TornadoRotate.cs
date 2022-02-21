using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoRotate : MonoBehaviour
{
    public Transform Pivot;

    void Update()
    {
        transform.RotateAround(Pivot.position, Vector3.up, 2 * Time.deltaTime);
    }
}
