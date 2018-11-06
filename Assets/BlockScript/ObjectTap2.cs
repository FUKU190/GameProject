using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap2 : MonoBehaviour
{
    private int ClickCount1;
    int numrandom2;
    float dis2;
    public GameObject PlayerPosision;
    private bool BlockActiv02;


    // Start is called before the first frame update
    void Start()
    {
        BlockActiv02 = false;
    }
    private void Update()
    {
        dis2 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision.transform.position);
        if(dis2 <= 1.5f)
        {
            BlockActiv02 = true;
        }
        else
        {
            BlockActiv02 = false;
        }
    }

    // Update is called once per frame
    public void OnClick()
    {
        Countrandom2();
        ClickCount1 = numrandom2;
        if (ClickCount1 == 1 || ClickCount1 == 8 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount1 == 2 || ClickCount1 == 9 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount1 == 3 || ClickCount1 == 10 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount1 == 4 || ClickCount1 == 11 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount1 == 5 || ClickCount1 == 12 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount1 == 6 || ClickCount1 == 13 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount1 == 7 || ClickCount1 == 14 && BlockActiv02)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    public void Countrandom2()
    {
        numrandom2 = Random.Range(1, 15);
    }
}
