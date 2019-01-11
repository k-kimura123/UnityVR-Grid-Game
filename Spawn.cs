using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour {
    public Transform[] SpawnPoints;
    public int spawnIndex;
    public float SpawnTime = 1.5f;
    public static bool SphereActive = true;
  //  public float SphereTimeRemaining = 10f;
  //  public float SphereTimeOut = 3f;

    public int score = 0;
    public int counter = 0;
  //  public int finalscore;
  //  public int flag = 0;
    

    //    public GameObject sphere;
    // Use this for initialization
    void Start () {

        // Invoke("SpawnSpheres", 1.5f);
        Debug.Log("start");

        SphereActive = true;

    }

    // Update is called once per frame
    void Update () {

        while (counter < 10)
        {
            spawnIndex = Random.Range(0, SpawnPoints.Length);
            SpawnPoints[spawnIndex].gameObject.SetActive(true);
            //SphereActive = true;

            if (SphereActive == true) //Deactivate once timer hits 0
            {

                //StartCoroutine(CheckActive());

            }
            else if (SphereActive == false)
            {


               // StopCoroutine(CheckActive());


            }

            //StartCoroutine(CheckActive());
            
            //flag = 1;
            //SphereTimeRemaining = SphereTimeOut;
            //if (SphereActive == true && SphereTimeRemaining == 0) //Deactivate once timer hits 0
            //{
            //    counter++;
            //    Debug.Log("timeout");
            //    SpawnPoints[spawnIndex].gameObject.SetActive(false);
            //    SphereActive = false;
            //    flag = 0; //Stop timer and invoke SpawnR
            //    Invoke("SpawnRepeat", 1.5f);

            //}
        }

        Debug.Log("GameOver. Your score is" + score);

        //if (flag == 1)
        //{
        //    SphereTimeRemaining -= Time.deltaTime;
        //}

        //else
        //{
        //    SphereTimeRemaining = SphereTimeOut;
        //    De
        //}
        //if(counter < 10)
        //{
        //   SphereTimeRemaining = SphereTimeRemaining - Time.deltaTime;
        //}



    }

    void SpawnSpheres()
    {
        

        while (counter < 10)
        {
            spawnIndex = Random.Range(0, SpawnPoints.Length);
            SpawnPoints[spawnIndex].gameObject.SetActive(true);
            SphereActive = true;
            StartCoroutine(CheckActive());
            //flag = 1;
            //SphereTimeRemaining = SphereTimeOut;
            //if (SphereAct/ive == true && SphereTimeRemaining == 0) //Deactivate once timer hits 0
            //{
            //    counter++;
            //    Debug.Log("timeout");
            //    SpawnPoints[spawnIndex].gameObject.SetActive(false);
            //    SphereActive = false;
            //    flag = 0; //Stop timer and invoke SpawnR
            //    Invoke("SpawnRepeat", 1.5f);

            //}
        } 

        Debug.Log("GameOver. Your score is" + score);
        

        
        
        //SphereActive = true;
        //SphereTimeRemaining = SphereTimeOut; //Timer initialized
        //flag = 1;   //Start timer
        
        
        //if (SphereActive == false && SphereTimeRemaining > 0 )
        //{
        //    counter++;
        //    score++;
        //    Debug.Log("+1 point");
        //    flag = 0;
        //    Invoke("SpawnRepeat", SpawnTime);
        //}
        
        
        
        
        //if (SphereTimeRemaining <= 0)
        //{
        //    SpawnPoints[spawnIndex].gameObject.SetActive(false);
        //    SphereActive = false;
        //    counter++;
        //    Debug.Log("timeout");
            

        //}
    }
   //void SpawnRepeat()
   // {
   //    while (counter < 10 && flag == 0)
   //     {
   //        Invoke("SpawnSpheres", SpawnTime);
   //     }
   //     if (counter == 10)
   //     {
   //         finalscore = score;
   //         Debug.Log("Your score is" + finalscore);
   //         return;
   //     }
   // }

    IEnumerator CheckActive()
    {




        

        if (SphereActive == true) //Deactivate once timer hits 0
        {

            yield return new WaitForSeconds(5.0f);

            if (SphereActive == true)
            {

            SphereActive = false;

            Debug.Log("timeout");
            SpawnPoints[spawnIndex].gameObject.SetActive(false);
            

            StopCoroutine(CheckActive());

            }

                
            // flag = 0; //Stop timer and invoke SpawnR
            // Invoke("SpawnRepeat", 1.5f);

        }
        else if (SphereActive == false)
        {
            score++;
            StopCoroutine(CheckActive());

            SphereActive = true;
            
            Debug.Log("+1 point!");


        }

        counter++;
        //yield return new WaitForSeconds(5);

    }
}
