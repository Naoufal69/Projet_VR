using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Room : MonoBehaviour
{
    [SerializeField] private bool roomComplete = false;
    [SerializeField] private GameObject door; 
    
    protected void roomIsComplete(bool newValue)
    {
        this.roomComplete = newValue; 
    }

    protected bool getRoomState()
    {
        return this.roomComplete; 
    }

    protected abstract bool isRoomComplete();

    protected void openDoor()
    {
        Destroy(this.door);
    }
}
