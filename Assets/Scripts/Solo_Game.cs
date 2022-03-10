using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solo_Game : MonoBehaviour
{
    public int Solo_Score { get; private set; } = 0;
    public int Duo_Score { get; private set; } = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Solo_Score += 1;
        }
    }

}
