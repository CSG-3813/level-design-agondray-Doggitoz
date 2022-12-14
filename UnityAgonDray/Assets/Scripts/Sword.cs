using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public int damage;
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit enemy");
            other.GetComponent<Enemy>().ReceiveDamage(damage);
        }
    }
}
