using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveBlock : MonoBehaviour
{
    public Rigidbody rb;
    public float upspeed;
    public float posision;
    Vector3 force;
    public GameObject player;
    public Text missionQuiz3;
    public CanvasGroup QuizCanvas;
    bool Up = true;
    public int Nolma;

    void Start()
    {
        Nolma = 4;
        upspeed = 0;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        rb.velocity = new Vector3(0, upspeed, 0);

        if (this.gameObject.transform.position.y > posision)
        {
            upspeed = 0;
            rb.isKinematic = true;
        }
        else if(this.gameObject.transform.position.y > posision - 3)
        {
            upspeed = 2.5f;
        }
    }
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && GameObject.Find("QuizObject").GetComponent<Quiz>().Crrent == Nolma)
        {
            missionQuiz3.text = "3問連続正解せよ！";
            StartCoroutine("QuizConbo");
        }
    }

    IEnumerator QuizCombo()
    {
        yield return new WaitForSeconds(2.0f);
        GameObject.Find("QuizObject").GetComponent<Quiz>().SetNextSentence();
        QuizCanvas.alpha = 1;
        QuizCanvas.interactable = true;

    }
    public void UpFloor()
    {
        if (Up)
        {
            Nolma += 4;
            rb.isKinematic = false;
            upspeed = 4;
            Up = false;
        }
        }
    }
