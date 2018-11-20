using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap6 : MonoBehaviour
{
    int TouchNum6, checknum6;
    public GameObject MoveBlock06, aura06;

    // Start is called before the first frame update
    void Start()
    {
        checknum6 = 0;
        aura06.SetActive(false);
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
        Countrandom6();
        if (TouchNum6 != checknum6)
        {
            checknum6 = TouchNum6;
            if (checknum6 == 1 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum6 == 2 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum6 == 3 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum6 == 4 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum6 == 5 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum6 == 6 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum6 == 7 && col02.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (TouchNum6 == checknum6)
        {
            Countrandom6();
        }
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock06.GetComponent<Renderer>().material.color)
        {
            aura06.SetActive(true);
        }
        else
        {
            aura06.SetActive(false);
        }
    }
    public void Countrandom6()
    {
        TouchNum6 = Random.Range(1, 8);
    }
}
