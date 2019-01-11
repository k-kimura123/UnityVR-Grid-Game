using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ControllerInput : MonoBehaviour
{

    // Use this for initialization

    // Update is called once per frame
    private SteamVR_TrackedObject trackedObj;
    public Vector3 tempPos;
    public float tempPosX;
    public float tempPosY;
    public float tempPosZ;
    public List<Vector3> posVector = new List<Vector3>();
    public List<float> posX = new List<float>();
    public List<float> posY = new List<float>();
    public List<float> posZ = new List<float>();
    public List<float> posMag = new List<float>();
    public float maxX;
    public float maxY;
    public float maxZ;
    public float maxreach;
    public float radiusmaxX;
    public float radiusmaxY;
    public float radiusmaxZ;
    public int indexmaxX;
    public int indexmaxY;
    public int indexmaxZ;
    public double adjustmentY = -0.35;
    public double adjustmentZ = 0.275;
    public static double centerX;
    public static double centerY;
    public static double centerZ;
    public static float finaldiameter;
    public static Vector3 finalscale;
    public static bool calibrated = false;



    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }
    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();    
    }
    void Update()
    {
        tempPos = transform.position;
        tempPosX = Mathf.Abs(transform.position.x);
        tempPosY = Mathf.Abs(transform.position.y);
        tempPosZ = Mathf.Abs(transform.position.z);
        //Debug.Log(transform.position);
        if (Controller.GetHairTrigger())
        {
            Debug.Log(gameObject.name + " Trigger Press");
            
            posVector.Add(tempPos);
            posX.Add(tempPosX);
            posY.Add(tempPosY);
            posZ.Add(tempPosZ);
            






        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            SphereScale();
            //SphereCalibration transform = new SphereCalibration();
            //transform.SphereTranslate();
            Debug.Log("Space button pressed for scale");
            Debug.Log(centerX);
            Debug.Log(finalscale);
            
        }
        //if (Input.GetKeyDown("t"))
        //{


        //    //SphereCalibration transform = new SphereCalibration();

        //    GameObject sphereTrans = GameObject.Find("Center").gameObject;
        //    sphereTrans.GetComponent<SphereCalibration>().SphereTranslate();
        //    Debug.Log("T button pressed for scale");
        //    calibrated = true;
        //}


    }

    void SphereScale()
    {
        maxX = posX.Max();
        maxY = posY.Max();
        maxZ = posZ.Max();
        indexmaxX = posX.IndexOf(maxX);
        
        indexmaxY = posY.IndexOf(maxY);
        
        indexmaxZ = posZ.IndexOf(maxZ);

        radiusmaxX = posVector[indexmaxX].magnitude;
        radiusmaxY = posVector[indexmaxY].magnitude;
        radiusmaxZ = posVector[indexmaxZ].magnitude;
        posMag.Add(radiusmaxX);
        posMag.Add(radiusmaxY);
        posMag.Add(radiusmaxZ);
        maxreach = posMag.Min();
        centerX = headsetInput.headposX;
        centerY = headsetInput.headposY + adjustmentY;
        centerZ = headsetInput.headposZ + adjustmentZ + (maxreach - adjustmentZ) / 2;
        finaldiameter = (float) (maxreach - adjustmentZ);
        finalscale = new Vector3(finaldiameter,finaldiameter,finaldiameter);

    }

     
}