﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap3 : MonoBehaviour
{
    private int ClickCount3;
    int numrandom3;
    float dis3;
    public GameObject PlayerPosision;
    bool BlockActiv;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        dis3 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision.transform.position);
        //Debug.Log(dis1);
        if (dis3 <= 1.5f)
        {

            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
    }

    // Update is called once per frame
    public void OnClick()
    {
        Countrandom3();
        ClickCount3 = numrandom3;
        if (ClickCount3 == 1 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount3 == 2 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount3 == 3 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount3 == 4 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount3 == 5 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount3 == 6 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount3 == 7 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom3()
    {
        numrandom3 = Random.Range(1, 7);
    }
}
