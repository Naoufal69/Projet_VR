using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salle1 : Room
{
    private GameObject Porte;
    public float porteVitesse = 1.0f; // Vitesse de déplacement de la porte

    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool isMoving = false;

    private void Start()
    {
        startPosition = new Vector3(Porte.transform.position.x, Porte.transform.position.y, Porte.transform.position.z);
        endPosition = new Vector3(Porte.transform.position.x, Porte.transform.position.y, -27.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "objet1_salle1" && !isMoving)
        {
            print("Collision");
            isRoomComplete();
            /*StartCoroutine(MoveDoor());*/
        }
    }

    IEnumerator MoveDoor()
    {
        isMoving = true;
        float journeyLength = Vector3.Distance(startPosition, endPosition);
        float distanceCovered = 0;

        while (distanceCovered < journeyLength)
        {
            float moveDistance = porteVitesse * Time.deltaTime;
            distanceCovered += moveDistance;
            Porte.transform.position = Vector3.MoveTowards(Porte.transform.position, endPosition, moveDistance);
            yield return null;
        }

        isMoving = false;
    }

    protected override bool isRoomComplete()
    {
            print("Collision");
            this.roomIsComplete(true);
            if (this.getRoomState())
            {
                this.openDoor();
                return true; 
            }
            return false;
    }
}
