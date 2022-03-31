using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealisticPhysic : MonoBehaviour
{
    private LayerMask CastMask;

    [SerializeField]
    //La position de la balle au moment de la frame précédente
    private Vector3 lastFramePosition;

    [SerializeField]
    //La position de la balle au moment de la frame actuelle
    private Vector3 currentFramePosition;

    [SerializeField]
    //Le rigidbody de la balle
    private Rigidbody rb;

    [SerializeField]
    //La vitesse de la balle
    private Vector3 velocity;

    [SerializeField]
    public float minVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        //On initialise la position de la balle à la frame précédente et actuelle
        lastFramePosition = transform.position;
        currentFramePosition = transform.position;
        //On initialise le rigidbody de la balle
        rb = GetComponent<Rigidbody>();
        //On initialise la vitesse de la balle
        velocity = rb.velocity;
        minVelocity = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //On met à jour les positions de la balle aux différentes frames
        lastFramePosition = currentFramePosition;
        currentFramePosition = transform.position;
        //On met à jour la vitesse de la balle
        velocity = rb.velocity;

        //On utilise un linecast pour savoir si la balle est en collision avec un objet
        if(Physics.Linecast(lastFramePosition, currentFramePosition, out RaycastHit hit, CastMask))
        {
            //Si c'est une raquette
            if(hit.collider.gameObject.tag == "Racket")
            {
                //On récupère la force de la raquette
                float racketForce = hit.collider.gameObject.GetComponent<Racket_Force>().getForce()/3.5f;
                //Si cette force est positive
                if(racketForce > 0)
                {
                    //On applique la force de la raquette sur la balle
                    rb.velocity = Vector3.Reflect(velocity, hit.normal) * (Mathf.Max(velocity.magnitude, minVelocity) / 30) * racketForce;
                }
                else
                {
                    //Sinon on applque un force par défaut sur la balle
                    rb.velocity = Vector3.Reflect(velocity, hit.normal) * (Mathf.Max(velocity.magnitude, minVelocity) / 4) * 3;
                }
            }
            //Sinon on applque un force par défaut sur la balle
            else
            {
                rb.velocity = Vector3.Reflect(velocity, hit.normal) * (Mathf.Max(velocity.magnitude, minVelocity) / 4) * 3;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = velocity.magnitude;
        var direction = Vector3.Reflect(velocity.normalized, collision.contacts[0].normal);
        if (collision.gameObject.tag == "Racket")
        {
            float racketForce = collision.gameObject.GetComponent<Racket_Force>().getForce()/3.5f;
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


