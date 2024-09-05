using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerDistroy : MonoBehaviour
{

    Transform bird;
    public float offset;

    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        if(bird.position.x - offset > transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
