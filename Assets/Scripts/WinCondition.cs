using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static int score = 0;
    public static GameObject porte;

    // Update is called once per frame
    void Update()
    {
        if (score == 3){
            porte = GameObject.FindWithTag("PORTE");
            Destroy(porte);
        }
    }
}
