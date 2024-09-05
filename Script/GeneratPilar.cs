
using Unity.VisualScripting;
using UnityEngine;
public class GeneratPilar : MonoBehaviour
{
    [SerializeField] GameObject pilerprefab;
    [SerializeField] Transform player;
    [SerializeField] float pileroffset;
    
    float lastposition = 0;  
    void Update()
    {
        if(player.position.x + pileroffset > lastposition) 
        {
            Generatpiller();          
        }      
    }   
    public void Generatpiller()
    {
        float a = Random.Range(-2,2);
        lastposition += pileroffset;
        var pos = new Vector3(lastposition,a);
        var p = Instantiate(pilerprefab);
        p.transform.position = pos;           
    }
    public void restartgame()
    {
        transform.position = Vector2.zero;
        overgame();
        lastposition = 0;
        Invoke("Generatpiller",1);
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
//2.13    -1.2