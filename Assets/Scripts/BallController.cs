using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Transform cam1;
    public Transform cam2;
    public float sidewaysAcceleration;
    public float forwardAcceleration;
    Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        
    }
            void Update() {
                if (gameObject.name == "Watermelon (1)"){
                    if (Input.GetKey(KeyCode.RightArrow)) {
                        rb.AddForce(cam1.right * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                    if (Input.GetKey(KeyCode.LeftArrow)) {
                        rb.AddForce(cam1.right * -1 * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }
                    if (Input.GetKey(KeyCode.UpArrow)) {
                        rb.AddForce(cam1.forward * forwardAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                    if (Input.GetKey(KeyCode.DownArrow)) {
                        rb.AddForce(cam1.forward * -1 * forwardAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                }
                if (gameObject.name == "Watermelon (2)"){
                    if (Input.GetKey(KeyCode.D)) {
                        rb.AddForce(cam2.right * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                    if (Input.GetKey(KeyCode.A)) {
                        rb.AddForce(cam2.right * -1 * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }
                    if (Input.GetKey(KeyCode.W)) {
                        rb.AddForce(cam2.forward * forwardAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                    if (Input.GetKey(KeyCode.S)) {
                        rb.AddForce(cam2.forward * -1 * forwardAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }
                }
               // rb.AddForce(cam.forward * forwardAcceleration, ForceMode.Force);
            }
}
