using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratPilar : MonoBehaviour
{
    [SerializeField] GameObject pilerprefab;
    [SerializeField] Transform player;
    [SerializeField] float pileroffset;
    [SerializeField] float destroypilar;
    float lastposition = 0;
    List<GameObject> pilar = new List<GameObject>();
    void Update()
    {
        if(player.position.x + pileroffset > lastposition) 
        {
            Generatpiller();          
        }
        if(player.position.x - pilar[0].transform.position.x > destroypilar)
        {
            Destroypilar();
        }
    }
    public void Generatpiller()
    {
        lastposition += pileroffset;
        var pos = new Vector2(lastposition,0);
        var p = Instantiate(pilerprefab);
        p.transform.position = pos;
        pilar.Add(p);
    }
    public void Destroypilar()
    {
        if(pilar.Count > 0 )
        {
            Destroy(pilar[0]);
           pilar.RemoveAt(0);
        }
    }
}
