using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap51 : MonoBehaviour
{
    private int ClickCount;
    public GameObject Floor5Block1, Floor5Block2, Floor5lock3, Floor5Block4;
    public GameObject Floor5Block5, Floor5Block6, Floor5Block7, Floor5Block8;
    public GameObject PlayerPosision05,joyController5;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv, Quizload;
    float dis4;
    public Text text;
    public CanvasGroup canvas05,missiontext4;
    bool Quizload5 = true;

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
        dis4 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision05.transform.position);
        //Debug.Log(dis1);
        if (dis4 <= num)
        {
            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Floor5Block1.GetComponent<Renderer>().material.color == Color.cyan))
        // (Floor5Block2.GetComponent<Renderer>().material.color == Color.cyan) &&
        // (Floor5lock3.GetComponent<Renderer>().material.color == Color.cyan) &&
        // (Floor5Block4.GetComponent<Renderer>().material.color == Color.cyan) &&
        // (Floor5Block5.GetComponent<Renderer>().material.color == Color.cyan) &&
        // (Floor5Block6.GetComponent<Renderer>().material.color == Color.cyan) &&
        // (Floor5Block7.GetComponent<Renderer>().material.color == Color.cyan) &&
        // (Floor5Block8.GetComponent<Renderer>().material.color == Color.cyan))
        {
            StartCoroutine("QuizStart5");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart5()
    {
        if (Quizload5)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext4.alpha = 1;
            joyController5.transform.position = new Vector2(1200, 120);
            yield return new WaitForSeconds(2.0f);
            canvas05.alpha = 1;
            canvas05.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 50;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload5 = false;
        }
    }
}