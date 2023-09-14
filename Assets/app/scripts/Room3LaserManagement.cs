using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3LaserManagement : Room
{

    [SerializeField] private List<Laser> lasers;
    

    // Update is called once per frame
    void Update()
    {
        launchLaserRay();
    }

    public void launchLaserRay()
    {
        foreach(Laser laser in this.lasers)
        {
            RaycastHit hit; 
            Ray ray = new Ray(laser.gameObject.transform.position, laser.gameObject.transform.forward);
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "receptor")
                {
                    laser.activateReceptor();
                }
                else
                {
                    laser.desactivateReceptor();
                    this.roomIsComplete(isRoomComplete()); 
                }
            }    
        }
    }

    protected override bool isRoomComplete()
    {
        foreach (Laser laser in this.lasers)
        {
            if (laser.getReceptorState())
            {
                Debug.Log("Pas Encore validée");
                return false; 
            }
        }
        Debug.Log("Salle validée");
        return true; 
    }
}
