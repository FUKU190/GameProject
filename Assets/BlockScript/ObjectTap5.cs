using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap5 : MonoBehaviour
{
    public GameObject Aura05;

    // Start is called before the first frame update
    void Start()
    {
        Aura05.SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
     
    }

    void OnCollisionEnter(Collision col05)
    {
        if (col05.gameObject.tag == "Player")
        {
            Aura05.SetActive(true);
            GameObject.Find("MoveBlock").GetComponent<MoveBlock>().PanelNum++;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
