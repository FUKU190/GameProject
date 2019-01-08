using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOllClrear : MonoBehaviour
{
    public GameObject Floor1Block1, Floor1Block2, Floor1Block3, Floor1Block4;
    public GameObject Floor2Block1, Floor2Block2, Floor2Block3, Floor2Block4;
    public GameObject Floor3Block1, Floor3Block2, Floor3Block3, Floor3Block4;
    public GameObject Floor4Block1, Floor4Block2, Floor4Block3, Floor4Block4;
    public GameObject Floor5Block1, Floor5Block2, Floor5Block3, Floor5Block4;
    public GameObject Floor6Block1, Floor6Block2, Floor6Block3, Floor6Block4;
    public GameObject Floor7Block1, Floor7Block2, Floor7Block3, Floor7Block4;
    public GameObject Aura1, Aura2, Aura3, Aura4, Aura5, Aura6, Aura7;
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
        if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 70)
        {
            Floor7Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor7Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor7Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor7Block4.GetComponent<Renderer>().material.color = Color.black;
            Floor7Block1.GetComponent<BoxCollider>().enabled = false;
            Floor7Block2.GetComponent<BoxCollider>().enabled = false;
            Floor7Block3.GetComponent<BoxCollider>().enabled = false;
            Floor7Block4.GetComponent<BoxCollider>().enabled = false;
            Destroy(Aura7);
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 60)
        {
            Floor6Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor6Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor6Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor6Block4.GetComponent<Renderer>().material.color = Color.black;
           
            Floor6Block1.GetComponent<BoxCollider>().enabled = false;
            Floor6Block2.GetComponent<BoxCollider>().enabled = false;
            Floor6Block3.GetComponent<BoxCollider>().enabled = false;
            Floor6Block4.GetComponent<BoxCollider>().enabled = false;
           
            Destroy(Aura6);
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 50)
        {
            Floor5Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor5Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor5Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor5Block4.GetComponent<Renderer>().material.color = Color.black;
            
            Floor5Block1.GetComponent<BoxCollider>().enabled = false;
            Floor5Block2.GetComponent<BoxCollider>().enabled = false;
            Floor5Block3.GetComponent<BoxCollider>().enabled = false;
            Floor5Block4.GetComponent<BoxCollider>().enabled = false;

            Destroy(Aura5);
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 40)
        {
            Floor4Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor4Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor4Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor4Block4.GetComponent<Renderer>().material.color = Color.black;
            
            Floor4Block1.GetComponent<BoxCollider>().enabled = false;
            Floor4Block2.GetComponent<BoxCollider>().enabled = false;
            Floor4Block3.GetComponent<BoxCollider>().enabled = false;
            Floor4Block4.GetComponent<BoxCollider>().enabled = false;
           
            Destroy(Aura4);
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 30)
        {
            Floor3Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor3Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor3Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor3Block4.GetComponent<Renderer>().material.color = Color.black;
            
            Floor3Block1.GetComponent<BoxCollider>().enabled = false;
            Floor3Block2.GetComponent<BoxCollider>().enabled = false;
            Floor3Block3.GetComponent<BoxCollider>().enabled = false;
            Floor3Block4.GetComponent<BoxCollider>().enabled = false;
           
            Destroy(Aura3);
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 20)
        {
            Floor2Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor2Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor2Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor2Block4.GetComponent<Renderer>().material.color = Color.black;
            
            Floor2Block1.GetComponent<BoxCollider>().enabled = false;
            Floor2Block2.GetComponent<BoxCollider>().enabled = false;
            Floor2Block3.GetComponent<BoxCollider>().enabled = false;
            Floor2Block4.GetComponent<BoxCollider>().enabled = false;
            
            Destroy(Aura2);
        }
        else if (GameObject.Find("QuizObject").GetComponent<Quiz>().Count >= 10)
        {
            Floor1Block1.GetComponent<Renderer>().material.color = Color.black;
            Floor1Block2.GetComponent<Renderer>().material.color = Color.black;
            Floor1Block3.GetComponent<Renderer>().material.color = Color.black;
            Floor1Block4.GetComponent<Renderer>().material.color = Color.black;
            
            Floor1Block1.GetComponent<BoxCollider>().enabled = false;
            Floor1Block2.GetComponent<BoxCollider>().enabled = false;
            Floor1Block3.GetComponent<BoxCollider>().enabled = false;
            Floor1Block4.GetComponent<BoxCollider>().enabled = false;
            
            Destroy(Aura1);
        }
    }
}
