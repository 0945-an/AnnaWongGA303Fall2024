using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D cursorTexture;
    public Vector2 hotSpotCustom = Vector2.zero;
    private Vector2 hotSpotAuto;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 hotSpot;
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        hotSpotAuto = new Vector2(cursorTexture.width*2, cursorTexture.height*2);
        hotSpot = hotSpotAuto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
