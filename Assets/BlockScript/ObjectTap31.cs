using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap31 : MonoBehaviour
{
    private int ClickCount;
    public GameObject Floor3Block1, Floor3Block2, Floor3Block3, Floor3Block4;
    public GameObject Floor3Block5, Floor3Block6, Floor3Block7, Floor3Block8;
    public GameObject PlayerPosision03,joyController3;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv;
    bool Quizload3 = true;
    float dis3;
    public Text text;
    public CanvasGroup canvas03,missiontext2;

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
        dis3 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision03.transform.position);
        if (dis3 <= num)
        {
            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Floor3Block1.GetComponent<Renderer>().material.color == Color.green))
        // (Floor3Block2.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block3.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block4.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block5.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block6.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block7.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block8.GetComponent<Renderer>().material.color == Color.green))
        {  
            StartCoroutine("QuizStart3");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart3()
    {
        if (Quizload3)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            joyController3.transform.position = new Vector2(1200, 120);
            missiontext2.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            canvas03.alpha = 1;
            canvas03.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 30;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload3= false;
        }
    }
}