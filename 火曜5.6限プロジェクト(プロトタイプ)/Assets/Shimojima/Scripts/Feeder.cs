using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Feeder : MonoBehaviour
{
    [SerializeField]
    private GameObject startCall;
    private float r, g, b, a = 0;
    private bool alpha = false;

    void Start()
    {
        r = startCall.GetComponent<Text>().color.r;
        g = startCall.GetComponent<Text>().color.g;
        b = startCall.GetComponent<Text>().color.b;
        a = 1;
    }
    
    void Update()
    {
        FeedInOut();
    }

    private void FeedInOut()
    {
        if (alpha == false)
        {
            a -= 0.01f;
            startCall.GetComponent<Text>().color = new Color(r,g,b,a);
        }
        else if (alpha == true)
        {
            a += 0.01f;
            startCall.GetComponent<Text>().color = new Color(r, g, b, a);
        }

        if (startCall.GetComponent<Text>().color.a >= 1)
        {
            alpha = false;
        }
        else if (startCall.GetComponent<Text>().color.a <= 0)
        {
            alpha = true;
        }
    }
}
