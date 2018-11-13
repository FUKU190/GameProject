using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap5 : MonoBehaviour
{
    int TouchNum5, TouchCount5,checknum5;
    public GameObject Aura51;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void Update()
    {

    }

    void OnCollisionEnter(Collision col05)
    {
        Countrandom5();
        if (TouchCount5 != checknum5)
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
        else if (checknum5 == TouchNum5)
        {
            Countrandom5();
        }
    }
    public void Countrandom5()
    {
        TouchNum5 = Random.Range(1, 8);
    }
}
