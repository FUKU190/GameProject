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
    public GameObject player, quizUI,Controller;
    public Text missionQuiz3;
    public CanvasGroup QuizCanvas,Panel,missonText;
    public bool Up = true;
    public int Nolma,PanelNum,FloorCount;

    void Start()
    {
        FloorCount = 1;
        Nolma = 0;
        upspeed = 0;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        rb.velocity = new Vector3(0, upspeed, 0);

        if (this.gameObject.transform.position.y > posision)
        {
            GameObject.Find("QuizObject").GetComponent<Quiz>().posisionUp = false;
            upspeed = 0;
            rb.isKinematic = true;
        }
        else if (this.gameObject.transform.position.y > posision - 3)
        {
            upspeed = 2.5f;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && Nolma == PanelNum)
        {
            StartCoroutine("QuizCombo");
        }
        else if(this.gameObject.transform.position.y < 140 && this.gameObject.transform.position.y > posision && Nolma != PanelNum)
        {
            missonText.alpha = 1;
            missionQuiz3.text = "有効パネルが不足しています。パネルを点灯させてください";
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        missonText.alpha = 0;
    }

    IEnumerator QuizCombo()
    {
        missionQuiz3.text = "  3問連続正解せよ！";
        yield return new WaitForSeconds(1.3f);
        GameObject.Find("QuizObject").GetComponent<Quiz>().QuizLoad();
        QuizCanvas.alpha = 1;
        Panel.alpha = 1;
        QuizCanvas.interactable = true;
        Controller.SetActive(false);

    }
    public void UpFloor()
    {
        FloorCount++;
        Nolma += 7;
        rb.isKinematic = false;
        upspeed = 4;
        GameObject.Find("QuizObject").GetComponent<Quiz>().Count = 0;
        if (GameObject.Find("QuizObject").GetComponent<Quiz>().ClearCount == 7)
        {
            Destroy(quizUI);
        }
    }
}
