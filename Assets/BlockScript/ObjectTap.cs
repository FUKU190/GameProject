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
    public Animator ani1;
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
            if (checknum1 == 1 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
            else if (checknum1 == 2 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
            }
            else if (checknum1 == 3 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (checknum1 == 4 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (checknum1 == 5 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
            }
            else if (checknum1 == 6 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            }
            else if (checknum1 == 7 && col01.gameObject.tag == "Player")
            {
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            }
        }
        else if (numrandom == checknum1)
        {
            Countrandom();
        }

        if (gameObject.GetComponent<Renderer>().material.color == MoveBlock.GetComponent<Renderer>().material.color)
        {
            Aura01.SetActive(true);
        }
        else
        {
            Aura01.SetActive(false);
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
        if (Authorization == false)
        {
            MovingPlayer1.SPEED = 0;
            ani1.SetBool("Run", false);
            yield return new WaitForSeconds(1.5f);
            joystick.SetActive(false);
            TextBox.alpha = 1;
            canvas.alpha = 1;
            canvas.interactable = true;
            QuizObject.SetActive(true);
            Authorization = true;
        }
    }
}
