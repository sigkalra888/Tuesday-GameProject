using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    float m_posx;
    float m_posy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //m_posx = Input.mousePosition.x;
        //m_posy = Input.mousePosition.y;
        //transform.position = Camera.main.ScreenToWorldPoint(new Vector3(m_posx,m_posy,10.0f));

        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);

        if (transform.localEulerAngles.z >= 270 && transform.localEulerAngles.z <= 360 || transform.localEulerAngles.z == 0)
        {
            transform.localRotation = rotation;
        }

        //transform.localRotation = rotation;

    }
}
