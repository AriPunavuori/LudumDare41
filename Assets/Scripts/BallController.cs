using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float movingSensitivity;
    public float Speed;
	
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(Vector3.right * Time.deltaTime, Space.World);

        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
                transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }
    }
}
