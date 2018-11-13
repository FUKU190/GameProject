using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap : MonoBehaviour {


    private int Touchnum;
    public GameObject Block1, Block2, Block3, Block4;
    public GameObject Block5, Block6, Block7, Block8;
    public GameObject QuizObject,joystick,Aura01,MoveBlock;
    public CanvasGroup canvas,missiontext;
    int numrandom,checknum1;
    bool Authorization = false;
    public Text text;
    public CanvasGroup TextBox;
    public MovingPlayer MovingPlayer1;

    // Start is called before the first frame update
    void Start()
    {
        QuizObject.SetActive(false);
        Aura01.SetActive(false);
        canvas.alpha = 0;
        canvas.interactable = false;
        checknum1 = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col01)
    {
        Countrandom();
        if (numrandom != checknum1)
        {
            checknum1 = numrandom;
            Touchnum = numrandom;
            if (Touchnum == 1 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                Aura01.SetActive(false);
            }
            else if (Touchnum == 2 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                Aura01.SetActive(false);
            }
            else if (Touchnum == 3 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                Aura01.SetActive(true);
            }
            else if (Touchnum == 4 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                Aura01.SetActive(false);
            }
            else if (Touchnum == 5 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
                Aura01.SetActive(false);
            }
            else if (Touchnum == 6 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                Aura01.SetActive(false);
            }
            else if (Touchnum == 7 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                Aura01.SetActive(false);
            }
        }
        else if (numrandom == checknum1)
        {
            Countrandom();
        }
    }
    private void Update()
    {
        if ((Block1.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) )
        //(Block2.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) &&
        //(Block3.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) &&
        //(Block4.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) &&
        //(Block5.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) &&
        //(Block6.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) &&
        //(Block7.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color) &&
        //(Block8.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color))
        {
            StartCoroutine("QuizStart");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 8);
    }
    IEnumerator QuizStart()
    {
        missiontext.alpha = 1;
        yield return new WaitForSeconds(1.5f);
        if (Authorization == false)
        {
            MovingPlayer1.SPEED = 0;
            joystick.SetActive(false);
            TextBox.alpha = 1;
            canvas.alpha = 1;
            canvas.interactable = true;
            QuizObject.SetActive(true);
            Authorization = true;
        }
    }
}
