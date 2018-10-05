using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap4 : MonoBehaviour
{

    private int ClickCount4;
    int numrandom4;
    bool BlockActiv;
    float dis4;
    public GameObject PlayerPosision;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        dis4 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision.transform.position);
        //Debug.Log(dis1);
        if (dis4 <= 1.5f)
        {

            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
    }


    // Update is called once per frame
    public void OnClick()
    {
        Countrandom4();
        ClickCount4 = numrandom4;
        if (ClickCount4 == 4)
        {
            ClickCount4 = 1;
        }
        if (ClickCount4 == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount4 == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount4 == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount4 == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount4 == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount4 == 6)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount4 == 7)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom4()
    {
        numrandom4 = Random.Range(1, 7);
    }
}