using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap61 : MonoBehaviour
{
    public GameObject Floor6Block1, Floor6Block2, Floor6Block3, Floor6Block4;
    public GameObject joystick61,MoveBlock61,Aura61;
    public Text text;
    public CanvasGroup canvas06,missiontext5,textbox6;
    bool Quizload6 = true;

    // Start is called before the first frame update
    void Start()
    {
        Aura61.SetActive(false);

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col61)
    {
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