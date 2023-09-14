using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor : MonoBehaviour
{
    [SerializeField] private bool activate = true;

    public void setActivate(bool value)
    {
        this.activate = value; 
    }

    public bool getActivate()
    {
        return this.activate; 
    }
    
}
