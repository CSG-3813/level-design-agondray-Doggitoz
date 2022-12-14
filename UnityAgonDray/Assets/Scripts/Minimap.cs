using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Minimap : MonoBehaviour
{
    public RawImage minimap;
    public RenderTexture smallMinimap;
    public RenderTexture bigMinimap;
    

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    private void Start()
    {
        minimap.texture = smallMinimap;
    }

    // Update is called once per frame
    public void OnMinimap()
    {
        if (minimap.texture == smallMinimap)
        {
            minimap.texture = bigMinimap;
        }
        else
        {
            minimap.texture = smallMinimap;
        }
    }
}
