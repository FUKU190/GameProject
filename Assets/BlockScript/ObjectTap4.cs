using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap4 : MonoBehaviour
{
    int TouchNum4, checknum4;
    public GameObject MoveBlock04, aura04;

    // Start is called before the first frame update
    void Start()
    {
        checknum4 = 0;
        aura04.SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
       
    }
    void OnCollisionEnter(Collision col02)
    {
        if (TouchNum4 != checknum4)
        {
            Countrandom4();
            checknum4 = TouchNum4;
            if (checknum4 == 1 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum4 == 2 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum4 == 3 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum4 == 4 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum4 == 5 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum4 == 6 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum4 == 7 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (TouchNum4 == checknum4)
        {
            Countrandom4();
        }
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock04.GetComponent<Renderer>().material.color)
        {
            aura04.SetActive(true);
        }
        else
        {
            aura04.SetActive(false);
        }
    }
    public void Countrandom4()
    {
        TouchNum4 = Random.Range(1, 8);
    }
}