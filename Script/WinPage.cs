using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPage : MonoBehaviour
{
    public static bool isgameover = false;
    public GameObject toend;
    public void MovetoPlayGame()
    {
        toend.SetActive(false);
        isgameover = false;
    }

}
