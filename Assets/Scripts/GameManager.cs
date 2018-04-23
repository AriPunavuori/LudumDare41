using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject PersistentDataPrefab;
    public Text statusText;
    public Text elapsedTimeText;
    public Text bestTimeText;
    float elapsedTime = 0;
    public float countDownTimer;
    //PersistentDataStorage pd;
    public Rigidbody rb;
    public Rigidbody rb2;
    bool finished = false;
    float bestTime;
    public Text strikeText;
    float strikeTimer = 0;

    void Start() {

        bestTime = PlayerPrefs.GetFloat("bestTime", float.MaxValue);
        //PlayerPrefs.SetFloat("bestTime", float.MaxValue);

        //pd = GameObject.FindObjectOfType<PersistentDataStorage>();
        //if (pd == null) {
        //    var pdgo = Instantiate(PersistentDataPrefab);
        //    pd = pdgo.GetComponent<PersistentDataStorage>();
        //}

        strikeText.text = "";
        statusText.text = "";
        elapsedTimeText.text = "Time:  " + elapsedTime;
        //if (/*pd.*/bestTime == Mathf.Infinity) {
        //    bestTimeText.text = " Best Time: 0:00:00 " + /*pd.*/bestTime;
        //}
        bestTimeText.text = (" Best Time:  " + bestTime.ToString("n1") + "0");
    }

    private void Update() {
        if (!finished) {
            if (countDownTimer < 0) {
                statusText.text = "";
                elapsedTime += Time.deltaTime;
                rb.isKinematic = false;
                rb2.isKinematic = false;
                elapsedTimeText.text = ("Elapsed Time: " + elapsedTime.ToString("n1") + "0");
            } else {
                countDownTimer -= Time.deltaTime;
                statusText.text = ("Ready to go in: " + countDownTimer.ToString("n1"));
            }
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(0);
        }

        if (strikeTimer < 0) {
            statusText.text = "";
            print("haloo");
        } else {
            strikeTimer -= Time.deltaTime;
        }

    }
    void GameOver() {
        if (elapsedTime < bestTime) {
            /*pd.*/bestTime = elapsedTime;
            statusText.text = ("Wow! A new HighScore! " + elapsedTime.ToString("n1") + "0");
            elapsedTimeText.text = "";
            bestTimeText.text = "";
            PlayerPrefs.SetFloat("bestTime", elapsedTime);
        } else {
            statusText.text = ("Finished, your time was: " + elapsedTime.ToString("n1") + "0");
            elapsedTimeText.text = "";
            bestTimeText.text = "";
        }
    }

    public void Finished() {
        finished = true;
        GameOver();
    }

    public void Strike(GameObject melon) {
        //UI notification
        print("JEE");
        strikeTimer = 5f;
        strikeText.text = "Strike!!!" + melon.name;


    }

}
