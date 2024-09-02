using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratPilar : MonoBehaviour
{
    [SerializeField] GameObject pilerprefab;
    [SerializeField] Transform player;
    [SerializeField] float pileroffset;
   /* public Text text;
    private int score = 0;*/
    float lastposition = 0;
    // Update is called once per frame
    void Update()
    {
        if(player.position.x + pileroffset > lastposition)
        {
            Generatpiller();
           // uplodscore();
        }
        else if(player.position.x - pileroffset > lastposition)
        {
            Destroypilar();
            Destroy(gameObject);
        }
    }
    public void Generatpiller()
    {
        lastposition += pileroffset;
        var pos = new Vector2(lastposition,0);
        var p = Instantiate(pilerprefab);
        p.transform.position = pos;
        
    }
    /* private void uplodscore()
     {
         text.text = ""+ score.ToString();
     }*/
    public void Destroypilar()
    {
        for(float i = transform.position.x; i >= 0;i--)
        {
            lastposition -= pileroffset;
            var pos = new Vector2(lastposition, 0);
            var p = Instantiate(pilerprefab);
            p.transform.position = pos;
        }
    }
}
