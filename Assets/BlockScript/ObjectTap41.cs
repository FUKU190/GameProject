using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap41 : MonoBehaviour
{
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
        Aura41.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col4)
    {
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