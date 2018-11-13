using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap31 : MonoBehaviour
{
    private int TouchNum3;
    public GameObject Floor3Block1, Floor3Block2, Floor3Block3, Floor3Block4;
    public GameObject Floor3Block5, Floor3Block6, Floor3Block7, Floor3Block8;
    public GameObject joystickF3;
    int numrandom;
    bool Quizload3 = true;
    public Text text;
    public CanvasGroup canvas03,missiontext2,textbox3;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
  void OnCollisionEnter(Collision col3)
    {
        Countrandom();
        TouchNum3 = numrandom;

        if (TouchNum3 == 1 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (TouchNum3 == 2 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (TouchNum3 == 3 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (TouchNum3 == 4 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (TouchNum3 == 5 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (TouchNum3 == 6 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (TouchNum3 == 7 && col3.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    private void Update()
    {
        if ((Floor3Block1.GetComponent<Renderer>().material.color == Color.green))
        // (Floor3Block2.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block3.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block4.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block5.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block6.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block7.GetComponent<Renderer>().material.color == Color.green) &&
        // (Floor3Block8.GetComponent<Renderer>().material.color == Color.green))
        {  
            StartCoroutine("QuizStart3");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 15);
    }
    IEnumerator QuizStart3()
    {
        if (Quizload3)
        {
            joystickF3.SetActive(false);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext2.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            textbox3.alpha = 1;
            canvas03.alpha = 1;
            canvas03.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().Nolmacount = 30;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload3= false;
        }
    }
}