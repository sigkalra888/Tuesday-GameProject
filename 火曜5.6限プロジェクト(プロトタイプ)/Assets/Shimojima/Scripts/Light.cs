using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private int _myDir;
    private float _eulerAngle;
    private bool _angleCheck;
    [SerializeField]
    private GameObject pct;
    private PlayerControllerTest _pct;
    [SerializeField]
    private AngleCheck angC;
    void Start()
    {
        _pct = pct.GetComponent<PlayerControllerTest>();
    }
    
    void Update()
    {
        transform.localPosition = new Vector3(pct.transform.localPosition.x,-3.9f,0);
        _eulerAngle = angC.GetComponent<AngleCheck>().eulerAngle;
        _angleCheck = angC.GetComponent<AngleCheck>().angleCheck;
        _myDir = _pct.myDir;
        Debug.Log(_myDir);

        if (_myDir == 1)
        {
            LookLeft();
        }
        else if (_myDir == 0)
        {
            LookRight();
        }
    }

    private void LookRight()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);

        if (_eulerAngle < 360 && _eulerAngle > 270)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (_angleCheck)
        {
            transform.localRotation = rotation;
        }
    }

    private void LookLeft()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);

        if (_eulerAngle > 0 && _eulerAngle < 180)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (_angleCheck)
        {
            transform.localRotation = rotation;
        }
    }
}
