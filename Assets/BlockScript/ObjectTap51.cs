using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap51 : MonoBehaviour
{
    public GameObject Floor5Block1, Floor5Block2, Floor5lock3, Floor5Block4;
    public GameObject joystickF5,MoveBlock51,Aura51;
    public bool Quizload;
    public Text text;
    public CanvasGroup canvas05,missiontext4,textbox5;
    bool Quizload5 = true;

    // Start is called before the first frame update
    void Start()
    {
        Aura51.SetActive(false);
    }

    void OnCollisionEnter(Collision col5)
    {
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
       
    }
    IEnumerator QuizStart5()
    {
        if (Quizload5)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().AnimationStop();
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext4.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystickF5.SetActive(false);
            textbox5.alpha = 1;
            canvas05.alpha = 1;
            canvas05.interactable = true;

            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload5 = false;
        }
    }
}