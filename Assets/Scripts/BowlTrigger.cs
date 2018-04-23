using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BowlTrigger : MonoBehaviour {

    Rigidbody rb;
    public Vector3 MForce;
    Quaternion startRot;
    bool knockedOver;
    PinsCount pinsCount;
    //GameManager gm;
    GameObject melon;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startRot = transform.rotation;
        pinsCount = GetComponentInParent<PinsCount>();
        //gm = FindObjectOfType<GameManager>();
    }

    void Update () {
        if (knockedOver) {
            return;
        }
        //print(Mathf.Abs(transform.rotation.x - startRot.x));
        //print(Mathf.Abs(transform.rotation.z - startRot.z));
		if (Mathf.Abs( transform.rotation.x - startRot.x ) > 0.1 || 
                Mathf.Abs( transform.rotation.z - startRot.z) > 0.1 ) {
            //print("keila kaatu");
            pinsCount.PinFell(melon);
            knockedOver = true;
        }
    
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Watermelon" || other.gameObject.name == "Watermelon (1)") //korjaa
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.AddForce(MForce, ForceMode.Impulse);
            //print("osu");
            melon = other.gameObject;
            //gm.Strike(other.gameObject);

            //Destroy(gameObject);
        }
    }

}
