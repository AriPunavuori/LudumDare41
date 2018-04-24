using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GoalScript : MonoBehaviour {
    GameManager gm;
    CameraFollow1 cf1;
    CameraFollow2 cf2;
    public GameObject cam1;
    public GameObject cam2;
    int p;
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Watermelon (1)")
        {
            p = 1;
            cf1 = GameObject.FindObjectOfType<CameraFollow1>();
            cf1.StopFollowing();
        }
        if (other.gameObject.name == "Watermelon (2)")
        {
            p = 2;
            cf2 = GameObject.FindObjectOfType<CameraFollow2>();
            cf2.StopFollowing();
        }
    
        //tämä muutettuna intiksi other.gameObject.name
        gm = GameObject.FindObjectOfType<GameManager>();
        gm.Finished(p);
    }

}
