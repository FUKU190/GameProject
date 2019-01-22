using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap7 : MonoBehaviour
{
    public GameObject Aura07;

    // Start is called before the first frame update
    void Start()
    {
        Aura07.SetActive(false);
    }

    void OnCollisionEnter(Collision col07)
    {
        if (col07.gameObject.tag == "Player")
        {
            Aura07.SetActive(true);
            GameObject.Find("MoveBlock").GetComponent<MoveBlock>().PanelNum++;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
