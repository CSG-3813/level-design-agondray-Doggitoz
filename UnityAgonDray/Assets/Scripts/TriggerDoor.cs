using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] DoorController script;

    private void OnTriggerEnter(Collider other)
    {
        script.OpenDoor();
    }

    private void OnTriggerExit(Collider other)
    {
        script.CloseDoor();
    }

}
