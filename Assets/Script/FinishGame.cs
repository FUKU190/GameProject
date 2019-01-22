using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public GameObject joyStick,ResultPanel;
    public Text Goaltext;
    public MovingPlayer Moving0;
    float Time;
    public Animator ani0;
    public Quiz quiz;
    public float[] ranking = new float[10];
    int i;
    
    // Start is called before the first frame update
    void Start()
    {
        ResultPanel.SetActive(false);
        i = 0;
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Player"))
        {
            ResultPanel.SetActive(true);
            ani0.SetBool("Run", false);
            Moving0.SPEED = 0;
            joyStick.SetActive(false);
            Time = GameObject.Find("TimeObject").GetComponent<TimeController>().Timer + quiz.miss;
            ranking[i] = Time;
            PlayerPrefs.SetFloat("TimeScore", ranking[i]);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetFloat("TimeScore"));
        }
    }
    
}
