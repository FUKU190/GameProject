using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap21 : MonoBehaviour
{
    public GameObject Floor2Block1, Floor2Block2, Floor2Block3, Floor2Block4;
    public GameObject joystickF2, Aura21,MoveBlock21;
    bool Quizload = true;
    public Text text;
    public CanvasGroup canvas02, missiontext1, textbox2;

    // Start is called before the first frame update
    void Start()
    {
        Aura21.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col2)
    {
        if (gameObject.GetComponent<Renderer>().material.color == MoveBlock21.GetComponent<Renderer>().material.color)
        {
            Aura21.SetActive(true);
        }
        else
        {
            Aura21.SetActive(false);
        }
    }

    private void Update()
    {
        
        {
            StartCoroutine("QuizStart2");
        }
    }

    IEnumerator QuizStart2()
    {
        if (Quizload)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().AnimationStop();
            GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
            missiontext1.alpha = 1;
            yield return new WaitForSeconds(2.0f);
            joystickF2.SetActive(false);
            textbox2.alpha = 1;
            canvas02.alpha = 1;
            canvas02.interactable = true;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            Quizload = false;
        }
    }
}