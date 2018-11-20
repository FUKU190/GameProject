using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap7 : MonoBehaviour
{
    int TouchNum7, checknum7;
    public GameObject MoveBlock07, aura07;

    // Start is called before the first frame update
    void Start()
    {
        checknum7 = 0;
        aura07.SetActive(false);
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
        Countrandom2();
        if (TouchNum7 != checknum7)
        {
            checknum7 = TouchNum7;
            if (checknum7 == 1 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum7 == 2 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum7 == 3 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum7 == 4 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum7 == 5 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum7 == 6 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum7 == 7 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (TouchNum7 == checknum7)
        {
            Countrandom2();
        }
        if (gameObject.GetComponent<Renderer>().material.color == MoveBlock07.GetComponent<Renderer>().material.color)
        {
            aura07.SetActive(true);
        }
        else
        {
            aura07.SetActive(false);
        }
    }
    public void Countrandom2()
    {
        TouchNum7 = Random.Range(1, 8);
    }
}
