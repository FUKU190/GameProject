using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap31 : MonoBehaviour
{
    private int CheckNum31;
    public GameObject Floor3Block1, Floor3Block2, Floor3Block3, Floor3Block4;
    public GameObject Floor3Block5, Floor3Block6, Floor3Block7, Floor3Block8;
    public GameObject joystickF3,MoveBlock31,Aura31;
    int numrandom;
    bool Quizload3 = true;
    public Text text;
    public CanvasGroup canvas03,missiontext2,textbox3;
    public Animator ani31;

    // Start is called before the first frame update
    void Start()
    {
        CheckNum31 = 0;
        Aura31.SetActive(false);
    }


    // Update is called once per frame
    void OnCollisionEnter(Collision col3)
    {
        Countrandom3();
        if (CheckNum31 != numrandom)
        {
            CheckNum31 = numrandom;

            if (CheckNum31 == 1 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (CheckNum31 == 2 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (CheckNum31 == 3 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (CheckNum31 == 4 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (CheckNum31 == 5 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (CheckNum31 == 6 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (CheckNum31 == 7 && col3.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (CheckNum31 == numrandom)
        {
            Countrandom3();
        }

        if(gameObject.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color)
        {
            Aura31.SetActive(true);
        }
        else
        {
            Aura31.SetActive(false);
        }
    }
    private void Update()
    {
        if ((Floor3Block1.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color))
        // (Floor3Block2.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color) &&
        // (Floor3Block3.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color) &&
        // (Floor3Block4.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color) &&
        // (Floor3Block5.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color) &&
        // (Floor3Block6.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color) &&
        // (Floor3Block7.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color) &&
        // (Floor3Block8.GetComponent<Renderer>().material.color == MoveBlock31.GetComponent<Renderer>().material.color))
        {
            StartCoroutine("QuizStart3");
        }
    }
    public void Countrandom3()
    {
        numrandom = Random.Range(1, 8);
    }
    IEnumerator QuizStart3()
    {
        if (Quizload3)
        {
            ani31.SetBool("Run", false);
            ani31.SetBool("Wate", true);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext2.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystickF3.SetActive(false);
            textbox3.alpha = 1;
            canvas03.alpha = 1;
            canvas03.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 30;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload3= false;
        }
    }
}