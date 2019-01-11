using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public float timeleft = 3;
    public static int flag1 = 0;
    public Text countdownText;
    //public GameObject countdown;
    public GameObject presstext;
    public static bool countdownover = false;
    //public Color zm;
    // Use this for initialization
    void Start () {
        countdownText = GameObject.Find("Canvas").transform.Find("countdown").GetComponent<Text>();
        //countdown = GameObject.FindGameObjectWithTag("countdown");
        presstext = GameObject.FindGameObjectWithTag("presstext");
        //FIGURE OUT A WAY TO MAKE COUNTER FIRST INVISIBLE WITH OUT DISABLING IT
        //ALSO MAKE SURE "START"IS disabled after a few seconds
        
        //zm = countdownText.color;
        //zm.a = 0.0f;
        //countdown.gameObject.SetActive(false);
        //countdown = GameObject.FindObjectOfType(GameObject);
        //presstext = GameObject.FindGameObjectWithTag("presstext");
        //presstext.SetActive(true);
        countdownText.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        //countdownText.text = (""+timeleft);
        if (Input.GetKeyDown("t"))
        {
            Debug.Log("t was pressed");
            //flag = 1;
            presstext.SetActive(false);
            //zm.a = 255;
            countdownText.gameObject.SetActive(true);
            flag1 = 1;
             
        }

        
        if (flag1 == 1)
        {
            //float t = timeleft;
            //string seconds = t.ToString("f0");
            timeleft -= Time.deltaTime;
            countdownText.text = timeleft.ToString("f0");
            if (timeleft <= 1 && timeleft > 0)
            {
                //StopCoroutine("timer");

                countdownText.text = "Start";

            }
            if (timeleft <= 0)
            {

                countdownText.text = "";
                countdownover = true;
                flag1 = 0;
            }
            //countdownText.text = seconds;
            //print(timeleft);
        }

        
    }
    

    
}
