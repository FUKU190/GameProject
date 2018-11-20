using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap2 : MonoBehaviour
{
    int TouchNum2,checknum2;
    public GameObject MoveBlock02,aura02;

    // Start is called before the first frame update
    void Start()
    {
        aura02.SetActive(false);
        checknum2 = 0;
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
        Countrandom2();
        if (TouchNum2 != checknum2)
        {
            checknum2 = TouchNum2;
            if (checknum2 == 1 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum2 == 2 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum2 == 3 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum2 == 4 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum2 == 5 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum2 == 6 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum2 == 7 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (TouchNum2 == checknum2)
        {
            Countrandom2();
        }
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock02.GetComponent<Renderer>().material.color)
        {
            aura02.SetActive(true);
        }
        else
        {
            aura02.SetActive(false);
        }
    }
    public void Countrandom2()
    {
        TouchNum2 = Random.Range(1, 8);
    }
}
