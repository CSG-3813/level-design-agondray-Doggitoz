using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public GameObject sword;
    public int damage;


    // Start is called before the first frame update
    void Start()
    {
        sword.GetComponent<Sword>().damage = damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttack()
    {
        sword.GetComponent<Animator>().SetTrigger("SwingSword");
    }
}
