using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject BlueDoor;
    [SerializeField] GameObject RedDoor;
    [SerializeField] GameObject YellowDoor;


    #region GameManager Singleton
    static private GameManager gm; //refence GameManager
    static public GameManager GM { get { return gm; } } //public access to read only gm 

    //Check to make sure only one gm of the GameManager is in the scene
    void CheckGameManagerIsInScene()
    {

        //Check if instnace is null
        if (gm == null)
        {
            gm = this; //set am to this gm of the game object
            Debug.Log(gm + " Loaded");
        }
        else //else if am is not null an Game Manager must already exsist
        {
            Destroy(this.gameObject); //In this case you need to delete this gm
            Debug.Log("Game Manager exists. Deleting...");
        }
    }
    #endregion


    private void Awake()
    {
        CheckGameManagerIsInScene();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Door Unlocking Methods

    public void UnlockDoor(string color, int lockNumber)
    {
        Debug.Log("Door unlock attempt");
        if (lockNumber != 1 && lockNumber != 2)
        {
            return;
        }

        if (color.Equals("Blue"))
        {
            if (lockNumber == 1)
            {
                UnlockBlueOne();
            } 
            else
            {
                UnlockBlueTwo();
            }
        }
        else if (color.Equals("Red"))
        {
            if (lockNumber == 1)
            {
                UnlockRedOne();
            }
            else
            {
                UnlockRedTwo();
            }
        }
        else if (color.Equals("Yellow"))
        {
            if (lockNumber == 1)
            {
                UnlockYellowOne();
            }
            else
            {
                UnlockYellowTwo();
            }
        }
        else
        {
            Debug.LogWarning("Improper parameter");
            return;
        }
    }

    private void UnlockBlueOne()
    {
        BlueDoor.GetComponent<DoorController>().UnlockOne();
    }

    private void UnlockBlueTwo()
    {
        BlueDoor.GetComponent<DoorController>().UnlockTwo();
    }

    private void UnlockRedOne()
    {
        RedDoor.GetComponent<DoorController>().UnlockOne();
    }

    private void UnlockRedTwo()
    {
        RedDoor.GetComponent<DoorController>().UnlockTwo();
    }

    private void UnlockYellowOne()
    {
        YellowDoor.GetComponent<DoorController>().UnlockOne();
    }

    private void UnlockYellowTwo()
    {
        YellowDoor.GetComponent<DoorController>().UnlockTwo();
    }
    #endregion
}
