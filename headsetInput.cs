using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headsetInput : MonoBehaviour {
    public static float headposX;
    public static float headposY;
    public static float headposZ;
    // Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(transform.position);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            headposX = transform.position.x;
            headposY = transform.position.y;
            headposZ = transform.position.z;
            Debug.Log("Space pressed for Headset");
        }
    }
}
