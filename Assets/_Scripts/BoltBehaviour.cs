using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltBehaviour : MonoBehaviour {

    public AudioClip impact;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(impact, 10F);
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Scoring.point += 10;
            transform.localScale -= new Vector3(0.1F, 0.1f, 0.1f);
            audioSource.PlayOneShot(impact, 10F);
        }
    }











}
