using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

    public Transform Camera;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;

        if (Input.GetMouseButton(0))
        {
            transform.position = new Vector3(0, 0, -10);
            Timer.begin = true;
        }

        if (Timer.RoundedTime == 0)
        {
            transform.position = new Vector3(-13.8f, 0, -10);
        }
    }
}
