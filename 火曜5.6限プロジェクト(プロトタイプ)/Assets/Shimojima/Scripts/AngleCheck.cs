using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCheck : MonoBehaviour
{
    public float eulerAngle;
    public bool angleCheck;
    private Vector3 pos;
    private Quaternion rotation;
    [SerializeField]
    private GameObject pct;
    private PlayerControllerTest _pct;
    private int _myDir;

    private void Start()
    {
        _pct = pct.GetComponent<PlayerControllerTest>();
    }

    void Update()
    {
        transform.localPosition = new Vector3(pct.transform.localPosition.x, -3.9f, 0);
        _myDir = _pct.myDir;
        pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);

        eulerAngle = 360 - transform.eulerAngles.z;
        if (_myDir == 1)
        {
            LL();
        }
        else if (_myDir == 0)
        {
            LR();
        }
        
        
    }

    private void LR()
    {
        if (eulerAngle == 360 || eulerAngle > 0 && eulerAngle <= 90)
        {
            angleCheck = true;
        }
        else if (eulerAngle > 90 && eulerAngle < 360)
        {
            angleCheck = false;
        }
        transform.localRotation = rotation;
    }

    private void LL()
    {
        if (eulerAngle == 360 || eulerAngle < 360 && eulerAngle >= 270)
        {
            angleCheck = true;
        }
        else if (eulerAngle < 270 && eulerAngle > 0)
        {
            angleCheck = false;
        }
        transform.localRotation = rotation;
    }
}
