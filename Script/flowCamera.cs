using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x = target.position.x;
        transform.position = pos;
    }
}
