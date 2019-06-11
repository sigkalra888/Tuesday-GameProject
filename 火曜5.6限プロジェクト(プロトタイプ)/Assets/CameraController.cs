using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class CameraController : MonoBehaviour
{

    void Update()
    {


        if (TimerManager.instance.Count >= 100)
        {
            GameObject cameraObj = GameObject.Find("Main Camera");
            cameraObj.GetComponent<Camera>().orthographicSize = 7.4f;
            cameraObj.transform.position = new Vector3(-4.7f, 2.55f, 0);
        }

    }

    public void CameraSizeChange()
    {
        GameObject cameraObj = GameObject.Find("Main Camera");
        cameraObj.GetComponent<Camera>().orthographicSize = 7.4f;
        cameraObj.transform.position = new Vector3(-4.7f, 2.55f, 0);

    }

}
