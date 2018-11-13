using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap41 : MonoBehaviour
{
    private int TouchNum4;
    public GameObject Floor4Block1, Floor4Block2, Floor4Block3, Floor4Block4;
    public GameObject Floor4Block5, Floor4Block6, Floor4Block7, Floor4Block8;
    public GameObject joystickF4;
    int numrandom;
    bool Quizload;
    public Text text;
    public CanvasGroup canvas03,missiontext3,textbox4;
    bool Quizload4 = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col4)
    {
        Countrandom();
        TouchNum4 = numrandom;
        if (TouchNum4 == 1 || TouchNum4 == 8 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (TouchNum4 == 2 || TouchNum4 == 9 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (TouchNum4 == 3 || TouchNum4 == 10 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (TouchNum4 == 4 || TouchNum4 == 11 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (TouchNum4 == 5 || TouchNum4 == 12 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (TouchNum4 == 6 || TouchNum4 == 13 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (TouchNum4 == 7 || TouchNum4 == 14 && col4.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    private void Update()
    {

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
            joystickF4.SetActive(false);
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
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