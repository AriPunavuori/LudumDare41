using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinsCount : MonoBehaviour {

    int children;

	void Start () {
        children = transform.childCount;
	}
	
    public void PinFell() {
        children--;
        if (children <= 0) {
            print("kaato!!");
        }
    }

}
