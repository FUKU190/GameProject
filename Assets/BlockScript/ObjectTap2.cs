using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap2 : MonoBehaviour
{
    private int ClickCount1;
    int TouchNum2;


    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
        Countrandom2();
        ClickCount1 = TouchNum2;
        if (ClickCount1 == 1 || ClickCount1 == 8 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount1 == 2 || ClickCount1 == 9 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount1 == 3 || ClickCount1 == 10 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount1 == 4 || ClickCount1 == 11 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount1 == 5 || ClickCount1 == 12 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount1 == 6 || ClickCount1 == 13 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount1 == 7 || ClickCount1 == 14 && col02.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom2()
    {
        TouchNum2 = Random.Range(1, 15);
    }
}
