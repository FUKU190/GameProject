using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap5 : MonoBehaviour
{
    int TouchNum5,checknum5;
    public GameObject Aura05,MoveBlock05;

    // Start is called before the first frame update
    void Start()
    {
        checknum5 = 0;
        Aura05.SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
     
    }

    void OnCollisionEnter(Collision col05)
    {
        Countrandom5();
        if (TouchNum5 != checknum5)
        {
            checknum5 = TouchNum5;
            if (checknum5 == 1 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum5 == 2 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum5 == 3 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum5 == 4 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum5 == 5 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum5 == 6 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum5 == 7 && col05.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
       
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock05.GetComponent<Renderer>().material.color)
        {
            Aura05.SetActive(true);
        }
        else
        {
            Aura05.SetActive(false);
        }
    }
    public void Countrandom5()
    {
        TouchNum5 = Random.Range(1, 8);
    }
}
