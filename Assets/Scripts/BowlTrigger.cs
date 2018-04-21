using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlTrigger : MonoBehaviour {


	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject) {
            Destroy(gameObject);
        }
    }
}
