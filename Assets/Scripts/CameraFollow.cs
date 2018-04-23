using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraFollow : MonoBehaviour {
    public GameObject player;
    float dist;
    public float angleSpeed;

    void Update() {
        Vector3 direction = player.GetComponent<Rigidbody>().velocity.normalized;
        dist = Vector3.Distance(player.transform.position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position, player.GetComponent<Rigidbody>().position, Time.deltaTime * dist);

        float angle = Vector3.Angle(transform.forward, direction);


        var goalRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, Time.deltaTime * (angle / angleSpeed));

    }
}
//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;

//public class CameraFollow : MonoBehaviour {
//    public List<GameObject> players;
//    public float angleSpeed;
//    public float moveSpeed;
//    public Vector3 cameraView;


//    void Update() {
//        Vector3 playersPositions = Vector3.zero;
//        Vector3 playersSpeed = Vector3.zero;
//        foreach (GameObject player in players) {
//            //tässä otetaan player position
//            Rigidbody rb = player.GetComponent<Rigidbody>();
//            playersPositions = playersPositions + rb.position;
//            playersSpeed = playersSpeed + rb.velocity;
//        }
//        Vector3 targetSpeed = playersSpeed.normalized;
//        Vector3 target = playersPositions / players.Count;

//        var distance = Vector3.Distance(players[0].transform.position, players[1].transform.position); // Distance between players

//        float angle = Vector3.Angle(transform.forward, target); // Angle between camera view and middlepoint of players



//        var dist = Vector3.Distance(transform.position, target);
//        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * dist);
//        //transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, Time.deltaTime * angleSpeed);
//        var goalRotation = Quaternion.LookRotation(targetSpeed); // Where the camera should look
//        transform.rotation = goalRotation;
//        //transform.position = Vector3.MoveTowards(transform.position, target + (transform.position - target).normalized * distance * 2, Time.deltaTime * moveSpeed * dist);

//        //Vector3 direction = player.GetComponent<Rigidbody>().velocity.normalized;
//        //dist = Vector3.Distance(player.transform.position, transform.position);
//        //transform.position = Vector3.MoveTowards(transform.position, player.GetComponent<Rigidbody>().position + cameraView, Time.deltaTime * dist);

//        //float angle = Vector3.Angle(transform.forward, direction);
//        //var goalRotation = Quaternion.LookRotation(direction);
//        //transform.rotation = Quaternion.RotateTowards(transform.rotation, goalRotation, Time.deltaTime * (angle / angleSpeed));

//    }
//}