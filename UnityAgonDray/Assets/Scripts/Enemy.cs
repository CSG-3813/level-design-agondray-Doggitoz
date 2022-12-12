using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int unitHealth;
    [SerializeField] int damage;
    [SerializeField] float damageDebounceTime = 1f;
    float timeSinceLastHit = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastHit += Time.deltaTime;
        if (unitHealth <= 0)
        {
            //Death animation + audio
            Destroy(this.gameObject);
        }
    }

    public void ReceiveDamage(int dmg)
    {
        if (timeSinceLastHit > damageDebounceTime)
        {
            unitHealth -= dmg;
            //Play hit sound effect
            timeSinceLastHit = 0f;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Deal damage to player
            collision.gameObject.GetComponent<Player>().TakeDamage(damage);
        }
    }
}
