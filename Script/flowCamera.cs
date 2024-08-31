using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowCamera : MonoBehaviour
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
        if (WinPage.isgameover) return;
        var pos = transform.position;
        pos.x = target.position.x + offset . x;
        transform.position = pos;
       // WinPage.isgameover = true;  
    }   
}
