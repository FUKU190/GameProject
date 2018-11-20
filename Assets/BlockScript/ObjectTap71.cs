using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap71 : MonoBehaviour
{
    public GameObject Floor7Block1, Floor7Block2, Floor7Block3, Floor7Block4;
    public GameObject Floor7Block5, Floor7Block6, Floor7Block7, Floor7Block8;
    public GameObject Aura71,MoveBlock71,joystickF7;
    private int checknum7;
    int numrandom7;
    public Text text;
    public CanvasGroup canvas07,missiontext7,textbox7;
    bool Quizload7 = true;
    public MovingPlayer MovingPlayer7;
    public Animator ani71;

    // Start is called before the first frame update
    void Start()
    {
        Aura71.SetActive(false);
        checknum7 = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col7)
    {
        Countrandom7();
        if (numrandom7 != checknum7)
        {
            checknum7 = numrandom7;
            if (checknum7 == 1 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum7 == 2 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum7 == 3 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum7 == 4 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum7 == 5 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum7 == 6 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum7 == 7 && col7.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (numrandom7 == checknum7)
        {
            Countrandom7();
        }
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock71.GetComponent<Renderer>().material.color)
        {
            Aura71.SetActive(true);
        }
        else
        {
            Aura71.SetActive(false);
        }
    }
    private void Update()
    {
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
    public void Countrandom7()
    {
        numrandom7 = Random.Range(1, 8);
    }
    IEnumerator QuizStart7()
    {
        if (Quizload7)
        {
            MovingPlayer7.SPEED = 0;
            ani71.SetBool("Run", false);
            ani71.SetBool("Wate", true);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext7.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            textbox7.alpha = 1;
            canvas07.alpha = 1;
            canvas07.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 70;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload7 = false;
        }
    }
}