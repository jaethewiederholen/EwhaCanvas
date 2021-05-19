using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;


public class toggle : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update

    public Sprite picture, text;
    private SpriteRenderer spriteRender;
    bool flag;
    public void OnPointerDown(PointerEventData data)

    {
        UnityEngine.Debug.Log("tochstart");
    }
    public void OnPointerUp(PointerEventData data)
    {
        UnityEngine.Debug.Log("touchend");
    }
    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
        flag = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(isTouched())
        {
            if(flag == false)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            if(flag == false)
            {
                spriteRender.sprite = picture;
            }
            else
            {
                spriteRender.sprite = text;
            }
        }
    }

    public bool isTouched()
    {
        bool result = false;
        if(Input.touchCount == 1)
        {
            if(Input.touches[0].phase == TouchPhase.Ended)
            {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(wp.x, wp.y);
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {
                    result = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePos))
            {
                result = true;
            }
        }
        return result;
    }

}
