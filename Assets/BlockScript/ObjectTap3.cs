﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap3 : MonoBehaviour
{
    int TouchNum3,checknum3;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void Update()
    {
      
    }

    void OnCollisionEnter(Collision col03)
    {
        if (TouchNum3 != checknum3)
        {
            Countrandom3();
            checknum3 = TouchNum3;
            if (checknum3 == 1 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum3 == 2 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum3 == 3 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum3 == 4 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum3 == 5 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum3 == 6 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum3 == 7 && col03.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (TouchNum3 == checknum3)
        {
            Countrandom3();
        }
    }
    public void Countrandom3()
    {
        TouchNum3 = Random.Range(1, 15);
    }
}
