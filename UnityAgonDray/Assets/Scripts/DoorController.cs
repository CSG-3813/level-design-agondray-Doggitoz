using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DoorController : MonoBehaviour
{
    public bool isLocked = false;
    [SerializeField] AudioClip DoorOpenClip;
    [SerializeField] AudioClip DoorCloseClip;
    GameObject door;
    AudioSource AS;
    Animator anim;

    bool lockedOne = false;
    bool lockedTwo = false;
    bool isOpen = false;
    void Start()
    {
        door = transform.gameObject;
        AS = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        if (isLocked)
        {
            lockedOne = true;
            lockedTwo = true;
        }
    }

    public void TryOpenDoor()
    {
        if (isOpen)
        {
            return;
        }

        //LOGIC FOR LOCK DOOR
        if (lockedOne == false && lockedTwo == false)
        {
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        isOpen = true;
        anim.SetTrigger("OpenDoor");
        AS.clip = DoorOpenClip;
        AS.PlayOneShot(DoorOpenClip);
    }

    public void CloseDoor()
    {
        anim.SetTrigger("CloseDoor");
    }

    public void UnlockOne()
    {
        lockedOne = false;
    }

    public void UnlockTwo()
    {
        lockedTwo = false;
    }

}
