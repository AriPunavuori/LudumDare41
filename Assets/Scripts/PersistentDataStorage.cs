using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PersistentDataStorage : MonoBehaviour {

    public float bestTime = 5f;

    void Start() {
        DontDestroyOnLoad(gameObject);
    }
}
