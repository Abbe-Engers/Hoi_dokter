using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrikCount : MonoBehaviour
{

    Text PrikkerDisplay;

    // Use this for initialization
    void Start()
    {
        PrikkerDisplay = GetComponent<Text>();

        Counter.prik = 0;
    }

    // Update is called once per frame
    void Update()
    {            
        PrikkerDisplay.text = Counter.prik.ToString();
    }
}



public static class Counter
{
    public static int prik;
}