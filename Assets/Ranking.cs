using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public Text RankText;
    int min, sec;
    float scoretime;
    // Start is called before the first frame update
    void Start()
    {
        scoretime = PlayerPrefs.GetFloat("TimeScore");
        min = (int)scoretime / 60;
        sec = (int)scoretime % 60;
        RankText.text = min + ":" + sec.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
