using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ObjectTap : MonoBehaviour {


    private int ClickCount;
    public GameObject Block1, Block2, Block3, Block4;
    public GameObject Block5, Block6, Block7, Block8;
    public GameObject PlayerPosision,QuizObject;
    public CanvasGroup canvas;
    public MyScript MyScript;
    float num = 1.5f;
    int numrandom;
    public bool BlockActiv;
    float dis1,dis2;
    Vector3 pos1, pos2;
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
        if(ClickCount == 1 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if(ClickCount == 2 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if(ClickCount == 3 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (ClickCount == 4 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (ClickCount == 5 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (ClickCount == 6 && BlockActiv == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (ClickCount == 7 && BlockActiv == true)
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
        if ((Block1.GetComponent<Renderer>().material.color == Color.red) &&
            (Block2.GetComponent<Renderer>().material.color == Color.red) &&
            (Block3.GetComponent<Renderer>().material.color == Color.red) &&
            (Block4.GetComponent<Renderer>().material.color == Color.red) &&
            (Block5.GetComponent<Renderer>().material.color == Color.red) &&
            (Block6.GetComponent<Renderer>().material.color == Color.red) &&
            (Block7.GetComponent<Renderer>().material.color == Color.red) &&
            (Block8.GetComponent<Renderer>().material.color == Color.red))
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
        MyScript.speed = 0;
        text.text = "10問正解しろ！";
        yield return new WaitForSeconds(2.0f);
        canvas.alpha = 1;
        canvas.interactable = true;
        QuizObject.SetActive(true);
        yield return null;
    }
}
