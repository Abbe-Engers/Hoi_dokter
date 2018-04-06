using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour {

    Text timerDisplay;

	// Use this for initialization
	void Start () {
        timerDisplay = GetComponent<Text>();

        Timer.time = 20f;
        Timer.begin = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Timer.begin)
        {
            if (Timer.time > 0)
            {
                Timer.time -= Time.deltaTime;
                timerDisplay.text = Timer.RoundedTime.ToString();
                Timer.RoundedTime = Mathf.Floor(Timer.time);
            }

            
        }
	}
}

public static class Timer
{
    public static float time;
    public static bool begin;
    public static float RoundedTime;
}