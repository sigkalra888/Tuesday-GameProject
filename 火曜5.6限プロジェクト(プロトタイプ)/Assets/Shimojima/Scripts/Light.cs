using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    float m_posx;
    float m_posy;
    private int _myDir;
    [SerializeField]
    private PlayerControllerTest pct;
    void Start()
    {
        pct = pct.GetComponent<PlayerControllerTest>();
    }

    // Update is called once per frame
    void Update()
    {
        _myDir = pct.myDir;

        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);

        if (transform.localEulerAngles.z >= 270 && transform.localEulerAngles.z <= 360 || transform.localEulerAngles.z == 0)
        {
            transform.localRotation = rotation;
        }
        

    }
}
