using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitch : MonoBehaviour
{
    //the collider behind the front of the racket (black face)
    [SerializeField]
    public Collider frontCollider;

    //the collider behind the back of the racket (red face)
    [SerializeField]   
    public Collider backCollider;

    //the collider when it's not the front or the back of the racket
    [SerializeField]
    public Collider betweenCollider;

    //The front point of the racket
    [SerializeField]
    private Transform frontPoint;

    //The back point of the racket
    [SerializeField]
    private Transform backPoint;

    //The point wich will determine the direction of the collider
    [SerializeField]
    private Transform orientationPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        float frontDistanceVector = Vector3.Distance(frontPoint.position, orientationPoint.position);
        float backDistanceVector = Vector3.Distance(backPoint.position, orientationPoint.position);

        if (frontDistanceVector < backDistanceVector)
        {
            betweenCollider.enabled = false;
            frontCollider.enabled = true;
            backCollider.enabled = false;
        }
        else
        {
            betweenCollider.enabled = false;
            frontCollider.enabled = false;
            backCollider.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float frontDistanceVector = Vector3.Distance(frontPoint.position, orientationPoint.position);
        float backDistanceVector = Vector3.Distance(backPoint.position, orientationPoint.position);

        if (frontDistanceVector < backDistanceVector)
        {
            betweenCollider.enabled = false;
            frontCollider.enabled = true;
            backCollider.enabled = false;
        }
        else
        {
            betweenCollider.enabled = false;
            frontCollider.enabled = false;
            backCollider.enabled = true;
        }
    }
}
