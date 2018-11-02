using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FedeOut : MonoBehaviour
{
    float b;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        b = Panel.GetComponent<Image>().color.b;
        StartCoroutine("Fadeout");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Fadeout()
    {
        while (b < 3.5f)
        {
            Panel.GetComponent<Image>().color += new Color(0, 0, 0, -0.005f);
            b += 0.01f;
            yield return null;
        }
        if(b > 0)
        {
            Destroy(Panel);
        }
    }
}
