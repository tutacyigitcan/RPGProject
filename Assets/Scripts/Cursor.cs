using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursor : MonoBehaviour
{

    public GameObject CursorObject;
    public Sprite CursorBasic;
    public Sprite CursorHand;
    public Image CursorImage;
    
    
    private void Start()
    {
        UnityEngine.Cursor.visible = false;
    }

    private void Update()
    {
        CursorObject.transform.position = Input.mousePosition;

        if (Input.GetMouseButton(1))
        {
            CursorImage.sprite = CursorHand;
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            CursorImage.sprite = CursorBasic;
        }
        
    }
}
