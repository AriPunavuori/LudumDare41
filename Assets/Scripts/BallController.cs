using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

<<<<<<< HEAD
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
=======
    public float movingSensitivity;
    public float Speed;
	
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
>>>>>>> 52b5307598e69ac405bcd536b0d8d783285cd896

            transform.Translate(Vector3.right * Time.deltaTime, Space.World);

        }


<<<<<<< HEAD
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }
    }

=======
        if (Input.GetKey(KeyCode.LeftArrow))
        {
                transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }
    }
>>>>>>> 52b5307598e69ac405bcd536b0d8d783285cd896
}
