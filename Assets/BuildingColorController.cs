using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingColorController : MonoBehaviour {

    GameObject[] buildings;
    Renderer rend;
    public Color normalColor;
    Vector3 differenceDistance;
    public Transform center;
    public Color[] colors;

	void Start () {
        buildings = GameObject.FindGameObjectsWithTag("Building");
        rend = GetComponentInChildren<Renderer>();
        rend.material.color = normalColor;

        foreach(GameObject building in buildings) {
            var angle = Vector3.Angle(transform.forward, building.transform.position - transform.position);
            print(angle);
            float t = angle / 180;
            int n = colors.Length;
            int i = (int)(t * (n - 1) - 0.001f);
            float t2 = (t - i * 1.0f / (n - 1)) * (n - 1);

            building.GetComponent<Renderer>().material.color = Color.Lerp(colors[i], colors[i + 1], t2); 
            //Color.Lerp(Color.red, Color.blue, number);

            //building.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f));
            /*new Color( Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));*/

        }
        //Color.Lerp(Color.blue, Color.red, 0.5f);
	}

    
	
	void Update () {
	
        
	}
}
