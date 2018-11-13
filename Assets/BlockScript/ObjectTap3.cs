using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap3 : MonoBehaviour
{
    private int ClickCount3;
    int TouchNum3;

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
        Countrandom3();
        ClickCount3 = TouchNum3;
        if (ClickCount3 == 1 || ClickCount3 == 8 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if( ClickCount3 == 2 || ClickCount3 == 9 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount3 == 3 || ClickCount3 == 10 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount3 == 4 || ClickCount3 == 11 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount3 == 5 || ClickCount3 == 12 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount3 == 6 || ClickCount3 == 13 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount3 == 7 || ClickCount3 == 14 && col03.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom3()
    {
        TouchNum3 = Random.Range(1, 15);
    }
}
