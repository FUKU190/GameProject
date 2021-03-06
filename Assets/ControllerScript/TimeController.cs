﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public float Timer;
    public Text timetext,conditionstext;
    string min, sec;
    public GameObject joystick;
    public CanvasGroup Offcanvas;
    public GameObject _joystick;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        int minute = (int)Timer / 60;
        int second = (int)Timer % 60;
        min = minute.ToString();
        sec = second.ToString();
        if ((int)Timer % 60 < 10)
        {
            sec = "0" + sec;
        }
        timetext.text = min + ":" + sec;
    }
}
