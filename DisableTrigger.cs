using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTrigger : MonoBehaviour {

    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        //SetCollidingObject(other);
        other.gameObject.SetActive(false);
        SpawnNew.SphereActive = false;
        SpawnNew.flag2 = 1;
        SpawnNew.score++;
        SpawnNew.counter++;
        SpawnNew.flag = 1;
        
    }
}
