using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightG : MonoBehaviour
{
    private int _myDir;         //向いている方向
    private float _eulerAngle;  //現在のアングル
    private bool _angleCheck;

    [SerializeField]
    private GameObject pct;
    private PlayerControllerTest _pct;

    [SerializeField]
    private AngleCheck angC;

    [SerializeField]
    private float decrease;
    public float battery;

    [SerializeField]
    private float timeInterval;
    private float temptime;
    private float time;
    private bool timeCheack = false;

    [SerializeField]
    private float scaleChanger;
    private float lightScale;
    private float originScale;

    void Start()
    {
        originScale = transform.localScale.x;
        lightScale = scaleChanger * battery;
        transform.localScale = new Vector3(originScale + lightScale, originScale + lightScale, 1);
        _pct = pct.GetComponent<PlayerControllerTest>();
    }
    
    void Update()
    {
        if (PauseManager.instance.Pause) return;
        time += Time.deltaTime;
        if (time >= 3 && timeCheack == false)
        {
            timeCheack = true;
            time = 0;
        }

        if (timeCheack)
        {
            BatteryDown();
        }

        transform.localPosition = (_myDir==0)?new Vector3(pct.transform.localPosition.x, -3.5f, 0): new Vector3(pct.transform.localPosition.x-0.6f, -3.5f, 0);
        _eulerAngle = angC.GetComponent<AngleCheck>().eulerAngle;
        _angleCheck = angC.GetComponent<AngleCheck>().angleCheck;
        _myDir = _pct.myDir;
        //Debug.Log(_myDir);

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
        else if (_eulerAngle < 270 && _eulerAngle > 90)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 270);
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

        if (_eulerAngle > 0 && _eulerAngle < 90)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (_eulerAngle > 90 && _eulerAngle < 270)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }

        if (_angleCheck)
        {
            transform.localRotation = rotation;
        }
    }

    private void BatteryDown()
    {
        if (time >= temptime)
        {
            if (battery > 0)
            {
                battery -= decrease;
                LightScaleChange();
            }
            temptime = time + timeInterval;
        }
        
    }
    public void RangeUp()
    {
        battery = 100;
    }
    private void LightScaleChange()
    {
        lightScale = scaleChanger * battery;
        transform.localScale = new Vector3(originScale + lightScale, originScale + lightScale, 1);
    }
}
