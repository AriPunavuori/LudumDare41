using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Transform cam;
    public float sidewaysAcceleration;
    public float forwardAcceleration;
    Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        
    }
            void Update() {
                if (gameObject.name == "Watermelon"){
                    if (Input.GetKey(KeyCode.RightArrow)) {
                        rb.AddForce(cam.right * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                    if (Input.GetKey(KeyCode.LeftArrow)) {
                        rb.AddForce(cam.right * -1 * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }
                }
                if (gameObject.name == "Watermelon (1)"){
                    if (Input.GetKey(KeyCode.D)) {
                        rb.AddForce(cam.right * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }

                    if (Input.GetKey(KeyCode.A)) {
                        rb.AddForce(cam.right * -1 * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
                    }
                }
                rb.AddForce(cam.forward * forwardAcceleration, ForceMode.Force);
            }
}
