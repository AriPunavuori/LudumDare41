using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    float dist;
    public float angleSpeed;
    public Vector3 cameraView;

    void Update() {
        Vector3 direction = player.GetComponent<Rigidbody>().velocity.normalized;
        dist = Vector3.Distance(player.transform.position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, player.GetComponent<Rigidbody>().position + cameraView, Time.deltaTime * dist);

        float angle = Vector3.Angle(transform.forward, direction);
 

        var goalRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, Time.deltaTime * (angle / angleSpeed));

    }
}