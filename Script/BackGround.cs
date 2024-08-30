using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBird();
    }
    public void MoveBird()
    {
        var pos = transform.position;
        pos.x = Mathf.Max(pos.x - speed, 100f);
        transform.position = pos;
    }

}
