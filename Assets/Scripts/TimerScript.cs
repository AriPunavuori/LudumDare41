using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    float timer;
    public Text textTimer;
	
	void Update () {

        timer += Time.deltaTime;
        string s = " ";
        textTimer.text = s + timer;

		
	}
}
