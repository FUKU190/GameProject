using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap61 : MonoBehaviour
{
    private int TouchNum61, numrandom;
    public GameObject Floor6Block1, Floor6Block2, Floor6Block3, Floor6Block4;
    public GameObject Floor6Block5, Floor6Block6, Floor6Block7, Floor6Block8;
    public GameObject joystick61,MoveBlock61,Aura61;
    public Text text;
    public CanvasGroup canvas06,missiontext5,textbox6;
    bool Quizload6 = true;

    // Start is called before the first frame update
    void Start()
    {
        Aura61.SetActive(false);
        TouchNum61 = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col61)
    {
        Countrandom61();
        if (TouchNum61 != numrandom)
        {
            TouchNum61 = numrandom;
            if (TouchNum61 == 1 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (TouchNum61 == 2 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (TouchNum61 == 3 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (TouchNum61 == 4 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (TouchNum61 == 5 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (TouchNum61 == 6 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (TouchNum61 == 7 && col61.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
  
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color)
        {
            Aura61.SetActive(true);
        }
        else
        {
            Aura61.SetActive(false);
        }
    }
    private void Update()
    {
        if ((Floor6Block1.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block2.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block3.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block4.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block5.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block6.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block7.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color) &&
         (Floor6Block8.GetComponent<Renderer>().material.color == MoveBlock61.GetComponent<Renderer>().material.color))
        {
            StartCoroutine("QuizStart6");
        }
    }
    public void Countrandom61()
    {
        numrandom = Random.Range(1, 8);
    }
    IEnumerator QuizStart6()
    {
        if (Quizload6)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().AnimationStop();
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext5.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystick61.SetActive(false);
            textbox6.alpha = 1;
            canvas06.alpha = 1;
            canvas06.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload6 = false;
        }
    }
}