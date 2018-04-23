using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public Text statusText;
    public Text statusText1;
    public Text elapsedTimeText1;
    public Text bestTimeText1;
    public Text statusText2;
    public Text elapsedTimeText2;
    public Text bestTimeText2;
    float elapsedTime1 = 0;
    float elapsedTime2 = 0;
    public float countDownTimer;
    public Rigidbody rb;
    public Rigidbody rb2;
    bool finished1 = false;
    bool finished2 = false;
    float bestTime;
    string strikeText;
    float strikeTimer = 0;

    void Start() {

        bestTime = PlayerPrefs.GetFloat("bestTime", float.MaxValue);
        strikeText = "";

        statusText.text = "";

        statusText1.text = "";
        elapsedTimeText1.text = ("Time:  " + elapsedTime1.ToString("n1") + "0");
        bestTimeText1.text = ("Best Time:  " + bestTime.ToString("n1") + "0");
        statusText2.text = "";
        elapsedTimeText2.text = ("Time:  " + elapsedTime2.ToString("n1") + "0");
        bestTimeText2.text = ("Best Time:  " + bestTime.ToString("n1") + "0");
    }

    private void Update() {
        if (!finished1) {
            if (countDownTimer < 0) {
                statusText.text = "";
                elapsedTime1 += Time.deltaTime;
                rb.isKinematic = false;
                elapsedTimeText1.text = ("Elapsed Time: " + elapsedTime1.ToString("n1") + "0");
            } else {
                countDownTimer -= Time.deltaTime;
                statusText.text = ("Ready to go in: " + countDownTimer.ToString("n1"));
            }

        }
        if (!finished2) {
            if (countDownTimer < 0) {
                statusText2.text = "";
                elapsedTime2 += Time.deltaTime;
                rb2.isKinematic = false;
                elapsedTimeText2.text = ("Elapsed Time: " + elapsedTime2.ToString("n1") + "0");
            } else {
                countDownTimer -= Time.deltaTime;
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
    void GameOver(int p) {
        if (p == 1) {
            if (elapsedTime1 < bestTime) {
                bestTime = elapsedTime1;
                statusText1.text = ("Wow! A new HighScore! " + elapsedTime1.ToString("n1") + "0");
                elapsedTimeText1.text = "";
                bestTimeText1.text = "";
                PlayerPrefs.SetFloat("bestTime", elapsedTime1);
            } else {
                statusText1.text = ("Finished, your time was: " + elapsedTime1.ToString("n1") + "0");
                elapsedTimeText1.text = "";
                bestTimeText1.text = "";
            }
        }
        if (p == 2) { 
            if (elapsedTime2 < bestTime) {
                bestTime = elapsedTime2;
                statusText2.text = ("Wow! A new HighScore! " + elapsedTime2.ToString("n1") + "0");
                elapsedTimeText2.text = "";
                bestTimeText2.text = "";
                PlayerPrefs.SetFloat("bestTime", elapsedTime2);
            } else {
                statusText2.text = ("Finished, your time was: " + elapsedTime2.ToString("n1") + "0");
                elapsedTimeText2.text = "";
                bestTimeText2.text = "";
            }
        }
    }

    public void Finished(int p) {
        if (p == 1) {
            finished1 = true;
        } else if ( p == 2) {
            finished2 = true;
        }
        GameOver(p);
    }

    public void Strike(GameObject melon) {
        //UI notification
        print("JEE");
        strikeTimer = 5f;
        strikeText = "Strike!!!" + melon.name;
        statusText.text = strikeText;


    }

}
