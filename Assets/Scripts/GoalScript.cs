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
            cam1.transform.position = Vector3.MoveTowards(transform.position, new Vector3(15, -50, -55), Time.deltaTime);
            cam1.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30f, 0f, 0f), Time.deltaTime);

        }
        if (other.gameObject.name == "Watermelon (2)")
        {
            p = 2;
            cf2 = GameObject.FindObjectOfType<CameraFollow2>();
            cf2.StopFollowing();
            cam2.transform.position = Vector3.MoveTowards(transform.position, new Vector3(15, -50, -55), Time.deltaTime);
            cam2.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(30f, 0f, 0f), Time.deltaTime);
        }
    
        //tämä muutettuna intiksi other.gameObject.name
        gm = GameObject.FindObjectOfType<GameManager>();
        gm.Finished(p);
    }

}
