using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField]
    private GameObject texture;
    [SerializeField]
    private int warkSpeed;
    public int myDir = 0;

    private float texScale;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        texScale = texture.GetComponent<Transform>().localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myDir = 1;
            texScale = -0.5f;
            texture.transform.localScale = new Vector3(texScale, 0.5f, 1);
            rb2d.velocity = new Vector2(-warkSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myDir = 0;
            texScale = 0.5f;
            texture.transform.localScale = new Vector3(texScale, 0.5f, 1);
            rb2d.velocity = new Vector2(warkSpeed, 0);
        }
    }
}
