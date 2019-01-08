using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap8 : MonoBehaviour
{
    int TouchNum8, checknum8;
    public GameObject MoveBlock08, aura08;

    // Start is called before the first frame update
    void Start()
    {
        checknum8= 0;
        aura08.SetActive(false);
    }
    private void Update()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col08)
    {
        Countrandom8();
        if (TouchNum8!= checknum8)
        {
            checknum8= TouchNum8;
            if (checknum8 == 1 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum8== 2 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum8 == 3 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum8== 4 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum8== 5 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum8 == 6 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum8 == 7 && col08.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
      
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock08.GetComponent<Renderer>().material.color)
        {
            aura08.SetActive(true);
        }
        else
        {
            aura08.SetActive(false);
        }
    }
    public void Countrandom8()
    {
        TouchNum8 = Random.Range(1, 8);
    }
}
