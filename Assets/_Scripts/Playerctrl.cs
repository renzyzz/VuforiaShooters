using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playerctrl : MonoBehaviour {

    [SerializeField]
    GameObject Bolt;

    [SerializeField]
    GameObject Ship;

    private Rigidbody rb;

    float cooldown = 0.3f;
    float buffer;

	void Start ()
    {
        rb = GetComponent<Rigidbody> ();
        buffer = cooldown;

    }
	
	// Update is called once per frame
	void Update ()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        rb.velocity = movement * 4f;

        if (x != 0 && y != 0)
        {

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);

        }
       // bool isFiring = CrossPlatformInputManager.GetButton("Fire");
       if (CrossPlatformInputManager.GetButton("Fire"))
        {
            if (buffer <= 0)
            {
                Instantiate(Bolt, transform.position, transform.rotation);
                buffer = cooldown;
            }
            else
            {

                buffer -= Time.deltaTime;
            }



        }


	}
}
