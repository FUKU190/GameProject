using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap71 : MonoBehaviour
{
    private int ClickCount;
    public GameObject Floor7Block1, Floor7Block2, Floor7Block3, Floor7Block4;
    public GameObject Floor7Block5, Floor7Block6, Floor7Block7, Floor7Block8;
    public GameObject PlayerPosision07,joyController7;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv, Quizload;
    float dis7;
    public Text text;
    public CanvasGroup canvas07,missiontext6;
    bool Quizload7 = true;

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
        dis7 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision07.transform.position);
        if (dis7 <= num)
        {
            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Floor7Block1.GetComponent<Renderer>().material.color == Color.magenta))
        // (Floor7Block2.GetComponent<Renderer>().material.color == Color.magenta) &&
        // (Floor7Block3.GetComponent<Renderer>().material.color == Color.magenta) &&
        // (Floor7Block4.GetComponent<Renderer>().material.color == Color.magenta) &&
        // (Floor7Block5.GetComponent<Renderer>().material.color == Color.magenta) &&
        // (Floor7Block6.GetComponent<Renderer>().material.color == Color.magenta) &&
        // (Floor7Block7.GetComponent<Renderer>().material.color == Color.magenta) &&
        // (Floor7lock8.GetComponent<Renderer>().material.color == Color.magenta))
        {
            StartCoroutine("QuizStart7");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart7()
    {
        if (Quizload7)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            joyController7.transform.position = new Vector2(800, 120);
            missiontext6.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            canvas07.alpha = 1;
            canvas07.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 70;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload7 = false;
        }
    }
}