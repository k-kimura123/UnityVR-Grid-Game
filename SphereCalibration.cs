using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCalibration : MonoBehaviour {

    // Use this for initialization
    private Vector3 finalTranslate;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 finalTranslate = new Vector3((float)ControllerInput.centerX, (float)ControllerInput.centerY, (float)ControllerInput.centerZ);

            Debug.Log(finalTranslate);

        }
        if (Countdown.countdownover == true)
        {


            //SphereCalibration transform = new SphereCalibration();

            GameObject sphereTrans = GameObject.Find("Center").gameObject;
            sphereTrans.GetComponent<SphereCalibration>().SphereTranslate();
            Debug.Log("T button pressed for scale");
            ControllerInput.calibrated = true;
        }
    }

    public void SphereTranslate()
    {


        Vector3 finalTranslate = new Vector3((float)ControllerInput.centerX, (float)ControllerInput.centerY, (float)ControllerInput.centerZ);
        Debug.Log(finalTranslate);

        this.transform.position = finalTranslate;
        this.transform.localScale = ControllerInput.finalscale; 
    }
}
