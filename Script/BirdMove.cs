using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BirdMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float upspeed;
    Rigidbody2D rb;
    public GameObject toend;
    public countScore countScore;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();      
    }
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
    public void resetgame()
    {
        transform.position = Vector3.zero;
        countScore.Resetscor();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {//collision.collider.gameObject.name
        WinPage.isgameover = true;
         toend.SetActive(true);
          rb.velocity = Vector2.zero;        
        print("game is over");
    }    
}
