using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsGameObject : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == gameObject.tag){
            WinCondition.score++;
        }
    }

    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == gameObject.tag){
            WinCondition.score--;
        }
    }
}
