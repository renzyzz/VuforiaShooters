using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyBehaviour : MonoBehaviour {

    public Rigidbody rb;
    Transform player;
    public float speed;
   public static bool isdead = false;
    public GameObject rejouer;

    float count = 1;

    void Start()
    {
        

    }
	// Update is called once per frame
	void Update ()
    {
        if (isdead == false)
        {
            player = GameObject.FindWithTag("Player").transform;
            rb.transform.LookAt(player);

            rb.velocity = transform.forward * speed;
        }
        if (isdead == true && count == 1 )
        {

            Instantiate(rejouer)  ;
            
            count++;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            isdead = true;
        }
    }

   

}
