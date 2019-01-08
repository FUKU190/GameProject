using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public GameObject joyStick;
    public Text Goaltext;
    public MovingPlayer Moving0;
    float Time;
    public Animator ani0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider hit)
    {
        if(hit.CompareTag("Player"))
        {
            ani0.SetBool("Run", false);
            Moving0.SPEED = 0;
            joyStick.SetActive(false);
            Time = GameObject.Find("TimeObject").GetComponent<TimeController>().Timer;
            PlayerPrefs.SetFloat("TimeScore", Time);
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetFloat("TimeScore"));
        }
    }
    
}
