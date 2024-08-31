using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BirdMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float upspeed;
    Rigidbody2D rb;
    public GameObject toend;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (WinPage.isgameover) return;
        
        var pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * upspeed ;         
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {//collision.collider.gameObject.name
        WinPage.isgameover = true;
        toend.SetActive(true);
        
        print("game is over");
    }
}
