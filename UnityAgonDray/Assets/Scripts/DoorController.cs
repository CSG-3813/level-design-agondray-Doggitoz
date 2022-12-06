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
    Animator anim;
    void Start()
    {
        door = transform.gameObject;
        AS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        anim.SetTrigger("OpenDoor");
        AS.clip = DoorOpenClip;
        AS.PlayOneShot(DoorOpenClip);
    }

    public void CloseDoor()
    {
        door.SetActive(true);
    }

}
