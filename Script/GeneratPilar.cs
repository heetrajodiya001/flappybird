using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratPilar : MonoBehaviour
{
    [SerializeField] GameObject pilerprefab;
    [SerializeField] Transform player;
    [SerializeField] float pileroffset;
    
    float lastposition = 0;
    // Update is called once per frame
    void Update()
    {
        if(player.position.x + pileroffset > lastposition)
        {
            Generatpiller();
        }
    }
    public void Generatpiller()
    {
        lastposition += pileroffset;
        var pos = new Vector2(lastposition,0);
        var p = Instantiate(pilerprefab);
        p.transform.position = pos;
    }
}
