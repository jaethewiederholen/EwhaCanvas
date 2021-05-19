using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
using System.Collections.Specialized;
using System.Diagnostics;

public class changebutton : MonoBehaviour
{
    public Sprite nonclearimage;
    public Sprite clearimage;
    private SpriteRenderer spriteRender;
    public int clear = 0;

    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();

    }
    void Update()
    {
       // clear = clearAction.instance.isclear;

        //if (clear == 1)
        //{
        //    spriteRender.sprite = clearimage;

        //}
    }


}
