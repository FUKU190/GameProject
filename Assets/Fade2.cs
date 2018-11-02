using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade2 : MonoBehaviour
{
    public GameObject Panel1;
    private float c;

    void Start()
    {
        c = Panel1.GetComponent<Image>().color.a;
    }

    public void OnClick()
    {
        StartCoroutine("LoadSce2");
    }

    IEnumerator LoadSce2()
    {
        while (c < 3.5)
        {
            Panel1.GetComponent<Image>().color += new Color(0, 0, 0, 0.005f);
            c += 0.01f;
            yield return null;
        }
        SceneManager.LoadScene("Description");
    }
}
