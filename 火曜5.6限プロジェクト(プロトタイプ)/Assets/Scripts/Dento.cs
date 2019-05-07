using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dento : MonoBehaviour
{
    public GameObject button;
    public GameObject light;
    CircleCollider2D lightCollider;
    Light lightCom;
    [SerializeField]
    float lightRange;
    bool playerTouch;

    // Start is called before the first frame update
    void Start()
    {
        lightCom = light.GetComponent<Light>();
        lightCollider = light.GetComponent<CircleCollider2D>();
        light.SetActive(false);
        button.gameObject.SetActive(false);
        playerTouch = false;
    }

    // Update is called once per frame
    void Update()
    {
        lightCom.spotAngle = lightRange;
        lightCollider.radius = lightRange/16;
        if (playerTouch)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                light.SetActive(true);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            button.gameObject.SetActive(true);
            playerTouch = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        button.gameObject.SetActive(false);
        playerTouch = false;
    }
}
