using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField] private int hori;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (PauseManager.instance.Pause) return;
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-hori, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(hori, 0);
        }
    }
}
