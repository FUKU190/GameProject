using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap3 : MonoBehaviour
{
    private int ClickCount3;
    int numrandom3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnClick()
    {
        Countrandom3();
        ClickCount3 = numrandom3;
        if (ClickCount3 == 4)
        {
            ClickCount3 = 1;
        }
        if (ClickCount3 == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount3 == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount3 == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount3 == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount3 == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount3 == 6)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount3 == 7)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom3()
    {
        numrandom3 = Random.Range(1, 7);
    }
}
