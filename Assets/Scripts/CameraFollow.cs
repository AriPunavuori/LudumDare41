using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    float dist;


    void Update() {
        Vector3 direction = player.GetComponent<Rigidbody>().velocity.normalized;
        dist = Vector3.Distance(player.transform.position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, player.GetComponent<Rigidbody>().position, Time.deltaTime * dist);

        float angle = Quaternion.Angle(transform.rotation, player.transform.rotation);

        var goalRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, Time.deltaTime * (angle/12));

    }
}
