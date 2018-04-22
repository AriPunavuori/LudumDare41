using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistentDataStorage : MonoBehaviour {

    public int bestTime;

    void Start() {
        DontDestroyOnLoad(gameObject);
    }
}
