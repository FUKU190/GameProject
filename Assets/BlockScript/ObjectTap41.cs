using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap41 : MonoBehaviour
{
    private int TouchNum4, numrandom40;
    public GameObject Floor4Block1, Floor4Block2, Floor4Block3, Floor4Block4;
    public GameObject Floor4Block5, Floor4Block6, Floor4Block7, Floor4Block8;
    public GameObject joystickF4,MoveBlock41,Aura41;
    bool Quizload;
    public Text text;
    public CanvasGroup canvas03,missiontext3,textbox4;
    bool Quizload4 = true;

    // Start is called before the first frame update
    void Start()
    {
        TouchNum4 = 0;
        Aura41.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col4)
    {
        Countrandom();
        if (numrandom40 != TouchNum4)
        {
            TouchNum4 = numrandom40;
            if (TouchNum4 == 1 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (TouchNum4 == 2 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (TouchNum4 == 3 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (TouchNum4 == 4 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (TouchNum4 == 5 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (TouchNum4 == 6 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (TouchNum4 == 7 && col4.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        if (gameObject.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color)
        {
            Aura41.SetActive(true);
        }
        else
        {
            Aura41.SetActive(false);
        }
    }
    private void Update()
    {

        if ((Floor4Block1.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block2.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block3.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block4.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block5.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block6.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block7.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color) &&
         (Floor4Block8.GetComponent<Renderer>().material.color == MoveBlock41.GetComponent<Renderer>().material.color))
        {
            StartCoroutine("QuizStart4");
        }
    }
    public void Countrandom()
    {
        numrandom40 = Random.Range(1, 8);
    }
    IEnumerator QuizStart4()
    {
        if (Quizload4)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().AnimationStop();
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext3.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystickF4.SetActive(false);
            textbox4.alpha = 1;
            canvas03.alpha = 1;
            canvas03.interactable = true;

            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload4 = false;
        }
    }
}