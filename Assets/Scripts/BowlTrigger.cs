using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlTrigger : MonoBehaviour {

    Rigidbody rb;
    public Vector3 MForce;

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
		
    
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name != "track_1.1")
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(MForce, ForceMode.Impulse);
            //Destroy(gameObject);
        }
    }

}
