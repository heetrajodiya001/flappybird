using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratePiler : MonoBehaviour
{

    [SerializeField] GameObject pilerPrefab;
    [SerializeField] Transform player;
    [SerializeField] float pilerOffset;

    float lastPosition = 0f;
    

    private void Update()
    {
        if (player.position.x + pilerOffset > lastPosition)
        {
            GenerateObstacal();
            //SceneManager.LoadScene("Demo");
        }
    }

    private void GenerateObstacal()
    {
        lastPosition += pilerOffset;
        var pos = new Vector2(lastPosition,0);
        var p = Instantiate(pilerPrefab);
        p.transform.position = pos;
    }
}
