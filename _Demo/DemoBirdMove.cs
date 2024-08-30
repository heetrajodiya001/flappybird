using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoBirdMove : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float upSpeed;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 
    void Update()
    {
        var pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * upSpeed;
            //rb.velocity = new Vector2(0,upSpeed);
        }
    }

}
