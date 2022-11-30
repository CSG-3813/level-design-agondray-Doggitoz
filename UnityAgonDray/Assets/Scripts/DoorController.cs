using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    GameObject door;

    void Start()
    {
        door = transform.gameObject;
    }

    public void OpenDoor()
    {
        door.SetActive(false);
    }

    public void CloseDoor()
    {
        door.SetActive(true);
    }

}
