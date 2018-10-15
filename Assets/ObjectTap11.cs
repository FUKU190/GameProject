using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap11 : MonoBehaviour
{
    private int ClickCount;
    public GameObject Floor2Block1, Floor2Block2, Floor2Block3, Floor2Block4;
    public GameObject Floor2Block5, Floor2Block6, Floor2Block7, Floor2Block8;
    public GameObject PlayerPosision02;
    public MyScript MyScript;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv,Quizload;
    float dis1;
    Vector3 pos1, pos2;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    public void OnClick()
    {
        Countrandom();
        ClickCount = numrandom;
        if (ClickCount == 1 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount == 2 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount == 3 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount == 4 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount == 5 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount == 6 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount == 7 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    private void Update()
    {
        dis1 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision02.transform.position);
        //Debug.Log(dis1);
        if (dis1 <= num)
        {

            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Floor2Block1.GetComponent<Renderer>().material.color == Color.blue) )
        // (Floor2Block2.GetComponent<Renderer>().material.color == Color.blue) &&
        // (Floor2Block3.GetComponent<Renderer>().material.color == Color.blue) &&
        // (Floor2Block4.GetComponent<Renderer>().material.color == Color.blue) &&
        // (Floor2Block5.GetComponent<Renderer>().material.color == Color.blue) &&
        // (Floor2Block6.GetComponent<Renderer>().material.color == Color.blue) &&
        // (Floor2Block7.GetComponent<Renderer>().material.color == Color.blue) &&
        // (Floor2Block8.GetComponent<Renderer>().material.color == Color.blue))
        {
            Quizload = true;
            StartCoroutine("QuizStart2");
            Quizload = false;
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart2()
    {
        MyScript.speed = 0;
        text.text = "10問正解しろ！";
        yield return new WaitForSeconds(1.0f);
        GameObject.Find("ColorBlock1").GetComponent<ObjectTap>().Authorization = true;
        GameObject.Find("ColorBlock1").GetComponent<ObjectTap>().CheckAuthorization();
        if (Quizload)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().QuizReset();
            GameObject.Find("QuizObject").GetComponent<Quiz>(). count.text = "正解数：" + 0;
            //Quizload = false;
        }
    }
}