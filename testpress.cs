using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testpress : MonoBehaviour {
    public static int flag = 0;
    public GameObject presstext;
    public GameObject countdown;
	// Use this for initialization
	void Start () {
        countdown = GameObject.FindGameObjectWithTag("countdown");
        presstext = GameObject.FindGameObjectWithTag("presstext");
        countdown.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("t was pressed");
            //flag = 1;
            StartCount();
            Countdown.flag1 = 1;
            
        }


    }
    public void StartCount()
    {
        
        


        Debug.Log("Countdown started"); //////CHANGE COUNTDOWN METHOD  dont use coroutine
        presstext.SetActive(false);
        countdown.SetActive(true);
    }
}
