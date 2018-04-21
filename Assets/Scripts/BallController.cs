using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Transform cam;
    public float sidewaysAcceleration;
    Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(cam.right * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(cam.right * -1 * sidewaysAcceleration * Time.deltaTime, ForceMode.Acceleration);
        }
    }
}