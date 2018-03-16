using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroBehaviour : MonoBehaviour {

    public Rigidbody rb;
    Transform player;
    public float speed;



    void Start ()
    {
        if ( EnemyBehaviour.isdead == false)
        {
            player = GameObject.FindWithTag("Player").transform;
            rb.transform.LookAt(player);

            rb.AddForce(transform.forward * speed);
        }
    }

    void Update()
    {
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            EnemyBehaviour.isdead = true;
        }
    }

}
