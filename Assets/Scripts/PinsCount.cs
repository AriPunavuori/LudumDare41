using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinsCount : MonoBehaviour {

    int children;
    GameManager gm;

    void Start () {
        children = transform.childCount;
        gm = FindObjectOfType<GameManager>();
    }
	
    public void PinFell(GameObject melon) {
        children--;
        if (children <= 0) {
            print("kaato!!");
            gm.Strike(melon);
        }
    }

    

}
