using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public Text RankText;
    int min, sec;
    float scoretime;
    public FinishGame timescore;
    string[] timestr = new string[10];
    // Start is called before the first frame update
    void Start()
    {
        DesplayRank();
    }

    public void DesplayRank()
    {
        for(int i = 0; i < 10; i++)
        {
            timestr[i] = timescore.ranking[i].ToString();
        }
        if (PlayerPrefs.HasKey("TimeScore"))
        {
            PlayerPrefs.GetFloat("TimeScore");
            min = (int)scoretime / 60;
            sec = (int)scoretime % 60;
            RankText.text = min + ":" + sec.ToString();
        }
        else
        {
            RankText.text = "NO DATA";
        }
    }
}
