using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3LaserManagement : MonoBehaviour
{

    [SerializeField] private List<GameObject> lasers;
    [SerializeField] private List<GameObject> lasersReceptors; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        launchLaserRay();
    }

    public void launchLaserRay()
    {
        foreach (GameObject laser in this.lasers)
        {
            int iteration = lasers.IndexOf(laser); 
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(laser.transform.position, laser.gameObject.transform.forward, out hit, 3))
            {
                if (hit.collider.gameObject.tag == "receptor")
                {
                    Debug.DrawRay(laser.transform.position, laser.gameObject.transform.forward * 3f, Color.red);
                    Debug.Log("Did Hit");
                    Debug.Log(iteration + "marche");
                }
                else
                {
                    Debug.DrawRay(laser.transform.position, laser.gameObject.transform.forward * 3f, Color.blue);
                    Debug.Log("Did not Hit");
                    Debug.Log(iteration + "marche pas");
                }
                
            }
        }
    }
}
