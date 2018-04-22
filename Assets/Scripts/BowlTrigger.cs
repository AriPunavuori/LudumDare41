﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BowlTrigger : MonoBehaviour {

    Rigidbody rb;
    public Vector3 MForce;
    Quaternion startRot;
    bool knockedOver;
    PinsCount pinsCount;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startRot = transform.rotation;
        pinsCount = GetComponentInParent<PinsCount>();
    }

    void Update () {
        if (knockedOver) {
            return;
        }
        //print(Mathf.Abs(transform.rotation.x - startRot.x));
        //print(Mathf.Abs(transform.rotation.z - startRot.z));
		if (Mathf.Abs( transform.rotation.x - startRot.x ) > 0.1 || 
                Mathf.Abs( transform.rotation.z - startRot.z) > 0.1 ) {
            print("keila kaatu");
            pinsCount.PinFell();
            knockedOver = true;
        }
    
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Watermelon") //korjaa
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(MForce, ForceMode.Impulse);
            print("osu");

            //Destroy(gameObject);
        }
    }

}
