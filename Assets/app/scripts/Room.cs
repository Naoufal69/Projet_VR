using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Room : MonoBehaviour
{
    [SerializeField] private bool roomComplete = false;

    protected void roomIsComplete(bool newValue)
    {
        this.roomComplete = newValue; 
    }

    protected abstract bool isRoomComplete(); 
}
