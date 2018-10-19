using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOllClrear : MonoBehaviour
{
    public GameObject Floor1Block1, Floor1Block2, Floor1Block3, Floor1Block4, Floor1Block5, Floor1Block6, Floor1Block7, Floor1Block8;
    public GameObject Floor2Block1, Floor2Block2, Floor2Block3, Floor2Block4, Floor2Block5, Floor2Block6, Floor2Block7, Floor2Block8;
    public GameObject Floor3Block1, Floor3Block2, Floor3Block3, Floor3Block4, Floor3Block5, Floor3Block6, Floor3Block7, Floor3Block8;
    public GameObject Floor4Block1, Floor4Block2, Floor4Block3, Floor4Block4, Floor4Block5, Floor4Block6, Floor4Block7, Floor4Block8;
    public GameObject Floor5Block1, Floor5Block2, Floor5Block3, Floor5Block4, Floor5Block5, Floor5Block6, Floor5Block7, Floor5Block8;
    public GameObject Floor6Block1, Floor6Block2, Floor6Block3, Floor6Block4, Floor6Block5, Floor6Block6, Floor6Block7, Floor6Block8;
    public GameObject Floor7Block1, Floor7Block2, Floor7Block3, Floor7Block4, Floor7Block5, Floor7Block6, Floor7Block7, Floor7Block8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClearColor()
    {
        if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 10)
        {
            Floor1Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor1Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 20)
        {
            Floor2Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor2Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 30)
        {
            Floor3Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor3Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 40)
        {
            Floor4Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor4Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 50)
        {
            Floor5Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor5Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 60)
        {
            Floor6Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor6Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 70)
        {
            Floor7Block1.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block2.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block3.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block4.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block5.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block6.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block7.GetComponent<Renderer>().material.color = Color.white;
            Floor7Block8.GetComponent<Renderer>().material.color = Color.white;
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
        }
    }
}
