using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap21 : MonoBehaviour
{
    private int TouchCount21, randomnum2;
    public GameObject Floor2Block1, Floor2Block2, Floor2Block3, Floor2Block4;
    public GameObject Floor2Block5, Floor2Block6, Floor2Block7, Floor2Block8;
    public GameObject joystickF2, Aura21,MoveBlock21;
    bool Quizload = true;
    public Text text;
    public CanvasGroup canvas02, missiontext1, textbox2;
    public Animator ani21;
    public MovingPlayer MovingPlayer21;

    // Start is called before the first frame update
    void Start()
    {
        TouchCount21 = 0;
        Aura21.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col2)
    {
        Countrandom();
        if (TouchCount21 != randomnum2)
        {
            TouchCount21 = randomnum2;
            if (TouchCount21 == 1 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (TouchCount21 == 2 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (TouchCount21 == 3 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (TouchCount21 == 4 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (TouchCount21 == 5 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (TouchCount21 == 6 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (TouchCount21 == 7 && col2.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (TouchCount21 == randomnum2)
        {
            Countrandom();
        }

        if (gameObject.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color)
        {
            Aura21.SetActive(true);
        }
        else
        {
            Aura21.SetActive(false);
        }
    }

    public void Countrandom()
    {
        randomnum2 = Random.Range(1, 8);
    }

    private void Update()
    {
        if ((Floor2Block1.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) )
        // (Floor2Block2.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) &&
        // (Floor2Block3.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) &&
        // (Floor2Block4.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) &&
        // (Floor2Block5.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) &&
        // (Floor2Block6.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) &&
        // (Floor2Block7.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color) &&
        // (Floor2Block8.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color))
        {
            StartCoroutine("QuizStart2");
        }
    }

    IEnumerator QuizStart2()
    {
        if (Quizload)
        {
            MovingPlayer21.SPEED = 0;
            ani21.SetBool("Run", false);
            ani21.SetBool("Wate", true);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext1.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystickF2.SetActive(false);
            textbox2.alpha = 1;
            canvas02.alpha = 1;
            canvas02.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 20;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload = false;
        }
    }
}