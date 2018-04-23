using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoalScript : MonoBehaviour {
    GameManager gm;
    int p;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Watermelon (1)") {
            p = 1;
                }
        else if (other.gameObject.name == "Watermelon (2)") {
            p = 2;
        }
        //tämä muutettuna intiksi other.gameObject.name
        gm = GameObject.FindObjectOfType<GameManager>();
        gm.Finished(p);
    }

}
