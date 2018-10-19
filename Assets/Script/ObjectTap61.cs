using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap61 : MonoBehaviour
{
    private int ClickCount;
    public GameObject Floor6Block1, Floor6Block2, Floor6Block3, Floor6Block4;
    public GameObject Floor6Block5, Floor6Block6, Floor6Block7, Floor6Block8;
    public GameObject PlayerPosision06;
    public MyScript MyScript;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv, Quizload;
    float dis6;
    public Text text;
    public CanvasGroup canvas06,joystick06;
    bool Quizload6 = true;

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
        dis6 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision06.transform.position);
        //Debug.Log(dis1);
        if (dis6 <= num)
        {
            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Floor6Block1.GetComponent<Renderer>().material.color == Color.yellow))
        // (Floor6Block2.GetComponent<Renderer>().material.color == Color.yellow) &&
        // (Floor6Block3.GetComponent<Renderer>().material.color == Color.yellow) &&
        // (Floor6Block4.GetComponent<Renderer>().material.color == Color.yellow) &&
        // (Floor6Block5.GetComponent<Renderer>().material.color == Color.yellow) &&
        // (Floor6Block6.GetComponent<Renderer>().material.color == Color.yellow) &&
        // (Floor6Block7.GetComponent<Renderer>().material.color == Color.yellow) &&
        // (Floor6Block8.GetComponent<Renderer>().material.color == Color.yellow))
        {
            StartCoroutine("QuizStart6");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart6()
    {
        if (Quizload6)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            MyScript.speed = 0;
            joystick06.alpha = 0;
            joystick06.interactable = false;
            text.text = "10問正解しろ！";
            yield return new WaitForSeconds(2.0f);
            canvas06.alpha = 1;
            canvas06.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 60;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload6 = false;
        }
    }
}