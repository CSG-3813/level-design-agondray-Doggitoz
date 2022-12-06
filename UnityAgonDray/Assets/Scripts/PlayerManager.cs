using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region PlayerManager Singleton
    static private PlayerManager pm; 
    [HideInInspector] static public PlayerManager PM { get { return pm; } }

    [SerializeField] GameObject Player;

    void CheckManagerIsInScene()
    {

        //Check if instnace is null
        if (pm == null)
        {
            pm = this; 
            Debug.Log(pm);
        }
        else 
        {
            Destroy(this.gameObject); 
            Debug.Log("Player Manager exists. Deleting...");
        }
        Debug.Log(pm);
    }
    #endregion 

    private void Awake()
    {
        CheckManagerIsInScene();
    }
}
