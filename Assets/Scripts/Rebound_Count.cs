using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound_Count : MonoBehaviour
{
    public int rebound_Counter { get; private set; } = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(rebound_Counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
