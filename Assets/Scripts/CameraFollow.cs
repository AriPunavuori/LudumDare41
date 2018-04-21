using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    public float turnSpeed;
    public float moveSpeed;
    const float distance = 2f;

    Quaternion rotation = Quaternion.Euler(0, 0, 0);

    void Update() {
        Vector3 direction = player.GetComponent<Rigidbody>().velocity.normalized;
    
        transform.position = Vector3.MoveTowards(transform.position, player.GetComponent<Rigidbody>().position, Time.deltaTime * moveSpeed);


        var goalRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, Time.deltaTime * turnSpeed);

    }
}
