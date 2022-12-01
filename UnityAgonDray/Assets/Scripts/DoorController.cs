using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DoorController : MonoBehaviour
{
    [SerializeField] AudioClip DoorOpenClip;
    [SerializeField] AudioClip DoorCloseClip;
    GameObject door;
    AudioSource AS;
    void Start()
    {
        door = transform.gameObject;
        AS = GetComponent<AudioSource>();
    }

    public void OpenDoor()
    {
        transform.position += Vector3.up * 10;
        AS.clip = DoorOpenClip;
        AS.PlayOneShot(DoorOpenClip);
    }

    public void CloseDoor()
    {
        door.SetActive(true);
    }

}
