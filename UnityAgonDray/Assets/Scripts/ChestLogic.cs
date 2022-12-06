using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLogic : MonoBehaviour
{
    public string AnimParameter;
    public GameObject key;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger(AnimParameter);
            SpawnKey();
        }
    }

    //Function thats called after animation has finished
    public void SpawnKey()
    {
        Instantiate(key);
        key.transform.position = transform.position;
    }

}
