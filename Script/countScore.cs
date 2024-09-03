using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countScore : MonoBehaviour
{
    public Text text;
    int score = 0;
   
    void Update()
    {
        text.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score = score + 1;
        print("==>"+score);
    }
    public void Resetscor()
    {
        score = 0;
    }
}
