using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioClip keyCollect;
    string color;
    int keyNum;
    GameObject chest;
    ChestLogic chestScript;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(string newColor, int newKeyNum, GameObject chest)
    {
        color = newColor;
        keyNum = newKeyNum;
        this.chest = chest;
        chestScript = chest.GetComponent<ChestLogic>();
        CollectKey();
    }

    void CollectKey()
    {
        Debug.Log("PICKUP KEY");
        // THIS WASNT WORKING WTF chestScript.CloseChest();
        GameManager.GM.UnlockDoor(color, keyNum);
        AudioManager.AM.PlayEffect(keyCollect);
        //Other logic with UI
        Destroy(this.gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        CollectKey();
    }
}
