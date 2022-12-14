using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUISync : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Image healthBar;
    public float healthUpdater = 100f;

    private void Awake()
    {
        healthBar.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
