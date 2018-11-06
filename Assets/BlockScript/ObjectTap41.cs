using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap41 : MonoBehaviour
{
    private int ClickCount;
    public GameObject Floor4Block1, Floor4Block2, Floor4Block3, Floor4Block4;
    public GameObject Floor4Block5, Floor4Block6, Floor4Block7, Floor4Block8;
    public GameObject PlayerPosision04,joyController4;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv, Quizload;
    float dis4;
    public Text text;
    public CanvasGroup canvas03,missiontext3,textbox4;
    bool Quizload4 = true;

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
        dis4 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision04.transform.position);
        if (dis4 <= num)
        {

            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Floor4Block1.GetComponent<Renderer>().material.color == Color.gray))
        // (Floor4Block2.GetComponent<Renderer>().material.color == Color.gray) &&
        // (Floor4Block3.GetComponent<Renderer>().material.color == Color.gray) &&
        // (Floor4Block4.GetComponent<Renderer>().material.color == Color.gray) &&
        // (Floor4Block5.GetComponent<Renderer>().material.color == Color.gray) &&
        // (Floor4Block6.GetComponent<Renderer>().material.color == Color.gray) &&
        // (Floor4Block7.GetComponent<Renderer>().material.color == Color.gray) &&
        // (Floor4Block8.GetComponent<Renderer>().material.color == Color.gray))
        {
            StartCoroutine("QuizStart4");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 15);
    }
    IEnumerator QuizStart4()
    {
        if (Quizload4)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            joyController4.transform.position = new Vector2(1200, 120);
            missiontext3.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            textbox4.alpha = 1;
            canvas03.alpha = 1;
            canvas03.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 40;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload4 = false;
        }
    }
}