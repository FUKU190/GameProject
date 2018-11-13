using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap11 : MonoBehaviour
{
    private int TouchCount21;
    public GameObject Floor2Block1, Floor2Block2, Floor2Block3, Floor2Block4;
    public GameObject Floor2Block5, Floor2Block6, Floor2Block7, Floor2Block8;
    public GameObject joystickF2;
    int numrandom;
    bool Quizload = true;
    public Text text;
    public CanvasGroup canvas02,missiontext1,textbox2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col2)
    {
        Countrandom();
        TouchCount21 = numrandom;
        if (TouchCount21 == 1 || TouchCount21 == 8 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (TouchCount21 == 2 || TouchCount21 == 9 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (TouchCount21 == 3 || TouchCount21 == 10 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (TouchCount21 == 4 || TouchCount21 == 11 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (TouchCount21 == 5 || TouchCount21 == 12 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (TouchCount21 == 6 || TouchCount21 == 13 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (TouchCount21 == 7 || TouchCount21 == 14 && col2.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    private void Update()
    {
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
            joystickF2.SetActive(false);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext1.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            textbox2.alpha = 1;
            canvas02.alpha = 1;
            canvas02.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 20;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload = false;
        }
    }
}