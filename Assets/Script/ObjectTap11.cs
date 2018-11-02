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
    public GameObject PlayerPosision02,joyController2;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv;
    bool Quizload = true;
    float dis1;
    Vector3 pos1, pos2;
    public Text text;
    public CanvasGroup canvas02,missiontext1;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    public void OnClick()
    {
        Countrandom();
        ClickCount = numrandom;
        if (ClickCount == 1 || ClickCount == 8 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (ClickCount == 2 || ClickCount == 9 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (ClickCount == 3 || ClickCount == 10 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount == 4 || ClickCount == 11 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount == 5 || ClickCount == 12 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount == 6 || ClickCount == 13 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount == 7 || ClickCount == 14 && BlockActiv)
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
            StartCoroutine("QuizStart2");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }

    IEnumerator QuizStart2()
    {
        if (Quizload)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            joyController2.transform.position = new Vector2(800, 120);
            missiontext1.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            canvas02.alpha = 1;
            canvas02.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 20;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload = false;
        }
    }
}