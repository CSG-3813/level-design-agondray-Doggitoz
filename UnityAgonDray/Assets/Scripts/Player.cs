using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int PlayerHealth { get; private set; } = 100;
    [SerializeField] GameObject strikeHitBox;
    [SerializeField] float damageDebounceTime = 1f;
    float timeSinceLastHit = 0f;

    private void Awake()
    {
        
    }

    //CREATE A STATE MACHINE TO HANDLE THIS STUFF BETTER
    private void Update()
    {
        timeSinceLastHit += Time.deltaTime;
        if (PlayerHealth <= 0)
        {
            //Can smooth this out better I imagine
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (true /*click mouse*/ && true /*animation done playing*/)
        {
            strikeHitBox.SetActive(true);
        }
    }

    public void TakeDamage(int dmg)
    {
        if (timeSinceLastHit > damageDebounceTime)
        {
            PlayerHealth -= dmg;
            timeSinceLastHit = 0f;
        }
    }

}
