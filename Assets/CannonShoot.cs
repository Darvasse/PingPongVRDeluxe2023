using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject pingpongBat;
    public GameObject cannonBall;
    public Transform cannonBallSpawn;
    // Start is called before the first frame update
    private bool canShoot = true;
    public bool holdBat = false;


    // Update is called once per frame
    void Update()
    {
        if (holdBat)
        {
           if (canShoot){
                this.GetComponent<Transform>().rotation = Quaternion.Euler(0, Random.Range(-70, -106), 0);
                GameObject cannonBallClone = Instantiate(cannonBall, cannonBallSpawn.position, cannonBallSpawn.rotation);
                cannonBallClone.GetComponent<Rigidbody>().AddForce(cannonBallSpawn.forward * Random.Range(1200, 1500));
                Debug.Log("After AddForce :" + cannonBallClone.GetComponent<Rigidbody>().velocity);
                canShoot = false;
                StartCoroutine(WaitForShoot());
                Destroy(cannonBallClone, 5);
            } 
        }
    }

    IEnumerator WaitForShoot(){
        yield return new WaitForSeconds(5);
        canShoot = true;
        
    }


}
