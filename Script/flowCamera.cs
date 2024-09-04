using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class flowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
   
    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;       
    }
    void Update()
    {       
        var pos = transform.position;
        pos.x = target.position.x + offset . x;
        transform.position = pos;         
    }
}
