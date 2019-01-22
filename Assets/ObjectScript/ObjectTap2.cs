using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap2 : MonoBehaviour
{
    public GameObject aura02;
    public MoveBlock Move02;

    // Start is called before the first frame update
    void Start()
    {
        aura02.SetActive(false);
    }

    void OnCollisionEnter(Collision col02)
    {
        if (col02.gameObject.tag == "Player")
        {
            Move02.PanelNum++;
            aura02.SetActive(true);
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        } 
    }
}
