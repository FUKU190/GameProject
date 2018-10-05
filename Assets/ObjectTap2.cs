using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap2 : MonoBehaviour
{
    private int ClickCount1;
     int numrandom2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnClick()
    {
        Countrandom2();
        ClickCount1 = numrandom2;
        if (ClickCount1 == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount1 == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount1 == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount1 == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount1 == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount1 == 6)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount1 == 7)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom2()
    {
        numrandom2 = Random.Range(1, 7);
    }
}
