using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WinPage : MonoBehaviour
{
    public static bool isgameover = false;
    public GameObject toend;
    public BirdMove birdMove;
    private void Start()
    {
        if (birdMove == null)
        {
            birdMove = FindObjectOfType<BirdMove>();
        }
    }
    public void MovetoPlayGame()
    {
        toend.SetActive(false);
        isgameover = false;
        birdMove.resetgame();
    }
}
