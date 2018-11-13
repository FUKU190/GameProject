using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap4 : MonoBehaviour
{
    private int TouchCount4;
    int TouchNum4;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void Update()
    {
    
    }

    void OnCollisionEnter(Collision col04)
    {
        Countrandom4();
        TouchCount4= TouchNum4;
        if (TouchCount4 == 1 || TouchCount4 == 8 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (TouchCount4 == 2 || TouchCount4 == 9 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (TouchCount4 == 3 || TouchCount4 == 10 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (TouchCount4 == 4 || TouchCount4 == 11 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (TouchCount4 == 5 || TouchCount4 == 12 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (TouchCount4 == 6 || TouchCount4 == 13 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (TouchCount4 == 7 || TouchCount4 == 14 && col04.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom4()
    {
        TouchNum4 = Random.Range(1, 15);
    }
}