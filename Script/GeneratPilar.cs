using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratPilar : MonoBehaviour
{
    [SerializeField] GameObject pilerprefab;
    [SerializeField] Transform player;
    [SerializeField] float pileroffset;
    [SerializeField] float destroypilar = 0;
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
       // restartgame();
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
    public void restartgame()
    {
        transform.position = Vector2.zero;
        overgame();
        lastposition = 0;
        Invoke("Generatpiller",1);
        //GameObject pilar = GameObject.Find("anime");
    }
    private void overgame()
    {
        GameObject[] pillar = GameObject.FindGameObjectsWithTag("anime");
        print("===>"+pillar.Length);
        foreach (var item in pillar)
        {
            Destroy(item);
        }
        
    }
}