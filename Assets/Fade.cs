using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public GameObject Panel;
    float a;
    
    void Start()
    {
        a = Panel.GetComponent<Image>().color.a;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine("LoadSce");
        }
    }

    IEnumerator LoadSce()
    {        
        while (a < 20)
        {
            Panel.GetComponent<Image>().color += new Color(0, 0, 0, 0.0006f);
            a += 0.01f;
            yield return null;
        }
        SceneManager.LoadScene("Quzigame");
    }
}
