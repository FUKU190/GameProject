using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap : MonoBehaviour {


    private int ClickCount;
    public GameObject Block1, Block2, Block3, Block4;
    public GameObject Block5, Block6, Block7, Block8;
    public GameObject PlayerPosision,QuizObject,joystickbutton;
    public CanvasGroup canvas,missiontext;
    float num = 1.5f;
    int numrandom;
    bool BlockActiv;
    public bool Authorization = false;
    float dis1;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        QuizObject.SetActive(false);
        canvas.alpha = 0;
        canvas.interactable = false;
    }

    // Update is called once per frame
    public void OnClick()
    {
        Countrandom();
        ClickCount = numrandom;
        if(ClickCount == 1 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if(ClickCount == 2 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if(ClickCount == 3 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount == 4 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount == 5 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount == 6 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount == 7 && BlockActiv)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
    private void Update()
    {
        dis1 = Vector3.Distance(this.gameObject.transform.position, PlayerPosision.transform.position);
        //Debug.Log(dis1);
        if (dis1 <= num)
        {

            BlockActiv = true;
        }
        else
        {
            BlockActiv = false;
        }
        if ((Block1.GetComponent<Renderer>().material.color == Color.red) )
            //(Block2.GetComponent<Renderer>().material.color == Color.red) &&
            //(Block3.GetComponent<Renderer>().material.color == Color.red) &&
            //(Block4.GetComponent<Renderer>().material.color == Color.red) &&
            //(Block5.GetComponent<Renderer>().material.color == Color.red) &&
            //(Block6.GetComponent<Renderer>().material.color == Color.red) &&
            //(Block7.GetComponent<Renderer>().material.color == Color.red) &&
            //(Block8.GetComponent<Renderer>().material.color == Color.red))
        {
            StartCoroutine("QuizStart");
        }
    }
    public void Countrandom()
    {
        numrandom = Random.Range(1, 7);
    }
    IEnumerator QuizStart()
    { 
        missiontext.alpha = 1;
        yield return new WaitForSeconds(2.0f);
        CheckAuthorization();
    }
    public void CheckAuthorization(){
        if (Authorization == false)
        {
            joystickbutton.transform.position = new Vector2(54,54);
            canvas.alpha = 1;
            canvas.interactable = true;
            QuizObject.SetActive(true);
            Authorization = true;
        }
    }
}
