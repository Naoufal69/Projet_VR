using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private GameObject receptor;

    public void activateReceptor()
    {
        Receptor receptorScript = getReceptorScript(); 
        receptorScript.setActivate(true);
    }

    public void desactivateReceptor()
    {
        Receptor receptorScript = getReceptorScript();
        receptorScript.setActivate(false); 
    }

    private Receptor getReceptorScript()
    {
        return this.receptor.GetComponent<Receptor>(); 
    }

    public bool getReceptorState()
    {
        Receptor receptorScript = getReceptorScript();
        return receptorScript.getActivate(); 
    }
}
