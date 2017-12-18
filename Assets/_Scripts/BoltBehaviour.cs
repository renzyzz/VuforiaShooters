using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(other.gameObject);
            Scoring.point += 5;
            transform.localScale -= new Vector3(0.1F, 0.1f, 0.1f);
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Scoring.point += 10;
            transform.localScale -= new Vector3(0.1F, 0.1f, 0.1f);
        }
    }











}
