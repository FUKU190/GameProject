using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap51 : MonoBehaviour
{
    public GameObject Floor5Block1, Floor5Block2, Floor5lock3, Floor5Block4;
    public GameObject Floor5Block5, Floor5Block6, Floor5Block7, Floor5Block8;
    public GameObject joystickF5;
    int numrandom,checknum5;
    public bool Quizload;
    public Text text;
    public CanvasGroup canvas05,missiontext4,textbox5;
    bool Quizload5 = true;

    // Start is called before the first frame update
    void Start()
    {
        checknum5 = 0;
    }

    void OnCOllisionEnter(Collision col5)
    {
        Countrandom();
        if (numrandom != checknum5)
        {
            checknum5 = numrandom;
            if (checknum5 == 1 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum5 == 2 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum5 == 3 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum5 == 4 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum5 == 5 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum5 == 6 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum5 == 7 && col5.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (numrandom == checknum5)
        {
            Countrandom();
        }
    }
    private void Update()
    {
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
        // Update is called once per frame
        public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart5()
    {
        if (Quizload5)
        {
            joystickF5.SetActive(false); 
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext4.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            textbox5.alpha = 1;
            canvas05.alpha = 1;
            canvas05.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 50;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload5 = false;
        }
    }
}