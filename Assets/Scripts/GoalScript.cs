using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoalScript : MonoBehaviour {
    GameManager gm;

    private void OnTriggerEnter(Collider other) {
        gm = GameObject.FindObjectOfType<GameManager>();
        gm.Finished();
    }

}
