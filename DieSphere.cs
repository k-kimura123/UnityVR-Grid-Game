using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSphere : MonoBehaviour {

    public static bool sphereDied = false;
    public float timeout = 10.0f;

	// Use this for initialization
	void Start () {
		
	}

    private void OnEnable()
    {
        StartCoroutine(KillSphere());
        SpawnNew.flag = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator KillSphere()
    {
        
        yield return new WaitForSeconds(timeout);
        if(SpawnNew.SphereActive == true)
        {
            sphereDied = true;
            this.gameObject.SetActive(false);
            SpawnNew.SphereActive = false;
            SpawnNew.counter++;
            SpawnNew.flag = 1;
            SpawnNew.flag2 = 0;
        }
        
        StopCoroutine(KillSphere());
    }
}
