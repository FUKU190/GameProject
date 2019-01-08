using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap : MonoBehaviour {


    private int Touchnum;
    public GameObject Block1, Block2, Block3, Block4;
    public GameObject QuizObject,joystick,Aura01,MoveBlock;
    public CanvasGroup canvas,missiontext;
    int numrandom,checknum1;
    bool Authorization = false;
    public Text text;
    public Animator ani1;
    public CanvasGroup TextBox;
    public MovingPlayer Movingplayer;

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
        StartCoroutine("QuizStart");
       
    }
    private void Update()
    {
      //if(GameObject.Find("QuizObject").GetComponent<Quiz>().Count == 1)
        //{
        //    Aura01.SetActive(true);
       // }
    }

    IEnumerator QuizStart()
    {
        missiontext.alpha = 1;
        if (Authorization == false)
        {
            Movingplayer.SPEED = 0;
            ani1.SetBool("Run", false);
            ani1.SetBool("Wate", true);
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
