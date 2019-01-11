using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    // Use this for initialization
    public GameObject Instruction1;
    public GameObject Instruction2;
    public GameObject title;
    public GameObject videoimage;

    public GameObject complete;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instruction1.SetActive(false);
            Instruction1.SetActive(false);
            title.SetActive(false);
            videoimage.SetActive(false);
            complete.SetActive(true);
            StartCoroutine(Waitfewseconds());///// doesnt work DONT USE COROUTINE
            StopCoroutine(Waitfewseconds());
            SceneManager.LoadScene(1);


        }

    }

    IEnumerator Waitfewseconds()
    {
        yield return new WaitForSeconds(3);
    }
}
    
