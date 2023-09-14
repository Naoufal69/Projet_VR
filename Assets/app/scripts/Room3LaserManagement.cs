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
            Ray ray = new Ray(laser.transform.position, laser.gameObject.transform.forward); 
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "receptor")
                {
                    Debug.DrawRay(ray.origin, hit.collider.gameObject.transform.position, Color.red);
                    Debug.Log("Did Hit");
                    Debug.Log(iteration + "marche");
                }
                else
                {
                    Debug.DrawRay(ray.origin, ray.direction, Color.blue);
                    Debug.Log("Did not Hit");
                    Debug.Log(iteration + "marche pas");
                }
                
            }
        }
    }
}
