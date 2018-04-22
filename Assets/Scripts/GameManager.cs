using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject PersistentDataPrefab;
    public Text statusText;
    public Text elapsedTimeText;
    public Text bestTimeText;
    float elapsedTime = 0;
    public float countDownTimer;
    PersistentDataStorage pd;
    public Rigidbody rb;

    void Start() {
        pd = GameObject.FindObjectOfType<PersistentDataStorage>();
        if (pd == null) {
            var pdgo = Instantiate(PersistentDataPrefab);
            pd = pdgo.GetComponent<PersistentDataStorage>();
        }

        statusText.text = "";
        elapsedTimeText.text = "Time:  " + elapsedTime;
        bestTimeText.text = " Best Time:  " + pd.bestTime;
    }

    private void Update() {

        if (countDownTimer < 0) {
            statusText.text = ("");
            elapsedTime += Time.deltaTime;
            rb.isKinematic = false;
            elapsedTimeText.text = ("Elapsed Time: " + elapsedTime);
        } else {
            countDownTimer -= Time.deltaTime;
            statusText.text = ("" + countDownTimer);
        }
        
    }
}
