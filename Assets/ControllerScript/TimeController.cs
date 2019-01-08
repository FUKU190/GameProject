using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        int minute = (int)Timer / 60;
        int second = (int)Timer % 60;
        min = minute.ToString();
        sec = second.ToString();
        if ((int)Timer % 60 < 10)
        {
            sec = "0" + sec;
        }
        timetext.text = min + ":" + sec;

        if(Timer <= 0)
        {
            timetext.text = "0:00";
            _joystick.SetActive(false);
            Offcanvas.alpha = 0;
            Offcanvas.interactable = false;
            conditionstext.text = "TIME OVER";
        }
    }
}
