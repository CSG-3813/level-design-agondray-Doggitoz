using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPlay : MonoBehaviour
{
    public PuzzleScript puzzleScript;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Trigger start");
            puzzleScript.TriggerStart();
        }

        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            Debug.Log("Reset clear status");
            puzzleScript.ResetClearStatus();
        }
    }

    
}
