using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLogic : MonoBehaviour
{
    public string KeyColor;
    public int KeyNumber;
    public string AnimParameter;
    public GameObject key;
    Animator anim;
    bool opened = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!opened)
            {
                anim.SetTrigger(AnimParameter);
                SpawnKey();
                opened = true;
            }
        }
    }

    public void CloseChest()
    {
        anim.SetTrigger("CloseChest");
    }

    //Function thats called after animation has finished
    public void SpawnKey()
    {
        Instantiate(key);
        key.GetComponent<Key>().Init(KeyColor, KeyNumber, transform.gameObject);
    }

}
