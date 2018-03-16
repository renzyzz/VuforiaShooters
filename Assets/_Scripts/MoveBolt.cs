using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBolt : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    float lifeTime = 5f;
    float buffer;

    private void Awake()
    {
        buffer = lifeTime;
    }

    void Start ()
    {
        rb = GetComponent<Rigidbody>();


    }
	
	
	void Update ()
    {


        if (buffer <= 0)
        {
            Destroy(gameObject);

        }
        else
        {
            buffer -= Time.deltaTime;
        }

        

	}
    private void FixedUpdate()
    {
        rb.velocity = transform.forward * speed;
    }

}
