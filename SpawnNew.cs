using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNew : MonoBehaviour {

    public Transform[] SpawnPoints;
    public int[] SpawnTally;
    public int[] CapturedTally;
    public int spawnIndex;
    public static bool SphereActive;
    public int MaxSpawn = 2;

    public static int score = 0;
    public int displayscore;
    public int TotalAppearence = 10;
    public static int counter = 0;
    public static int flag = 0;
    public static int flag2 = 0;
    // Use this for initialization
    void Start () {

        spawnIndex = Random.Range(0, SpawnPoints.Length);
        SpawnTally = new int[SpawnPoints.Length];
        CapturedTally = new int[SpawnPoints.Length];
        
        

    }
	
	// Update is called once per frame
	void Update () {

        if (Countdown.countdownover == true)
        {
            SpawnPoints[spawnIndex].gameObject.SetActive(true);
            SphereActive = true;
            SpawnTally[spawnIndex]++;
            Countdown.countdownover = false;
        }
        if (counter < TotalAppearence && flag == 1)
            {
                spawnIndex = Random.Range(0, SpawnPoints.Length);
                while(SpawnTally[spawnIndex] == MaxSpawn)
                {
                    spawnIndex = Random.Range(0, SpawnPoints.Length);
                }
                SpawnPoints[spawnIndex].gameObject.SetActive(true);
                SpawnTally[spawnIndex]++;
                
                if(flag2 == 1)
                {
                    CapturedTally[spawnIndex]++;
                }
                SphereActive = true;
                displayscore = score;
            }
        else if (counter == TotalAppearence && flag == 1)
            {
                Debug.Log("Game Over. Your score is " + score + " out of " + TotalAppearence);
                SpawnPoints[spawnIndex].gameObject.SetActive(false);
                
            }
            
        }
        


    }
  
   
   