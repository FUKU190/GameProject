using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap3 : MonoBehaviour
{
    int TouchNum3, checknum3;
    public GameObject MoveBlock03, aura03;

    // Start is called before the first frame update
    void Start()
    {
        checknum3 = 0;
        aura03.SetActive(false);
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
        Countrandom2();
        if (TouchNum3 != checknum3)
        {
            checknum3 = TouchNum3;
            if (checknum3 == 1 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum3 == 2 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum3 == 3 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum3 == 4 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum3 == 5 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum3 == 6 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum3 == 7 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
       
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock03.GetComponent<Renderer>().material.color)
        {
            aura03.SetActive(true);
        }
        else
        {
            aura03.SetActive(false);
        }
    }
    public void Countrandom2()
    {
        TouchNum3 = Random.Range(1, 8);
    }
}
