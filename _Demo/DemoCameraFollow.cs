using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCameraFollow : MonoBehaviour
{

    [SerializeField] Transform target;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x = target.position.x + offset.x;
        transform.position = pos ; 
    }
}

