using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap51 : MonoBehaviour
{
    public GameObject Floor5Block1, Floor5Block2, Floor5lock3, Floor5Block4;
    public GameObject Floor5Block5, Floor5Block6, Floor5Block7, Floor5Block8;
    public GameObject joystickF5,MoveBlock51,Aura51;
    int numrandom5,checknum5;
    public bool Quizload;
    public Text text;
    public CanvasGroup canvas05,missiontext4,textbox5;
    bool Quizload5 = true;
    public Animator ani51;
    public MovingPlayer MovingPlayer5;

    // Start is called before the first frame update
    void Start()
    {
        checknum5 = 0;
        Aura51.SetActive(false);
    }

    void OnCollisionEnter(Collision col5)
    {
        Countrandom5();
        if (numrandom5 != checknum5)
        {
            checknum5 = numrandom5;
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
        else if (numrandom5 == checknum5)
        {
            Countrandom5();
        }

        if(gameObject.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color)
        {
            Aura51.SetActive(true);
        }
        else
        {
            Aura51.SetActive(false);
        }
    }
    private void Update()
    {
        if ((Floor5Block1.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color))
        // (Floor5Block2.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color) &&
        // (Floor5lock3.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color) &&
        // (Floor5Block4.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color) &&
        // (Floor5Block5.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color) &&
        // (Floor5Block6.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color) &&
        // (Floor5Block7.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color) &&
        // (Floor5Block8.GetComponent<Renderer>().material.color == MoveBlock51.GetComponent<Renderer>().material.color))
        {
            StartCoroutine("QuizStart5");
        }
    }
        // Update is called once per frame
        public void Countrandom5()
        {
            numrandom5 = Random.Range(1, 8);
        }
    IEnumerator QuizStart5()
    {
        if (Quizload5)
        {
            MovingPlayer5.SPEED = 0;
            ani51.SetBool("Run", false);
            ani51.SetBool("Wate", true);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext4.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystickF5.SetActive(false);
            textbox5.alpha = 1;
            canvas05.alpha = 1;
            canvas05.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 50;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload5 = false;
        }
    }
}