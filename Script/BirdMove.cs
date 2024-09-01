using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public void Resetgame()
    {
        var pos = transform.position;   
        pos.x = 0;
        transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {//collision.collider.gameObject.name
        WinPage.isgameover = true;
         toend.SetActive(true);
          rb.velocity = Vector2.zero;
        print("game is over");
    }
}
