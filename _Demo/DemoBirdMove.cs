using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBirdMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float upSpeed;
    Rigidbody2D rb;

    public static bool isGamePause = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isGamePause) return;

        var pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * upSpeed;
            //rb.velocity = new Vector2(0,upSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGamePause = true;
        rb.velocity = Vector2.zero;
    }

}
