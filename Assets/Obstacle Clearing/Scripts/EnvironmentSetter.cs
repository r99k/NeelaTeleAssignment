using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSetter : MonoBehaviour
{

    public GameObject floorOnRunning;
    public GameObject floorForward;
    void Update()
    {
        
        if (transform.position.z > floorOnRunning.transform.position.z + 39)
        {
            floorOnRunning.transform.position = new Vector3(0, -1.12f, floorForward.transform.position.z + 36);
            GameObject temp = floorOnRunning;
            floorOnRunning = floorForward;
            floorForward = temp;
          
        }
    }
    
}
