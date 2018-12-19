using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegen : MonoBehaviour
{

    // Use this for initialization
    [SerializeField] float MoveSpeed = 0.0f;
    float Pos;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Pos = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(Pos * MoveSpeed, 0f);
        Debug.Log("PENIS");
    }
}
