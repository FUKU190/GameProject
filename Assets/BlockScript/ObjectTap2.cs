using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap2 : MonoBehaviour
{
    int TouchNum2,checknum2;
    public GameObject MoveBlock02,aura02;

    // Start is called before the first frame update
    void Start()
    {
        aura02.SetActive(false);
        checknum2 = 0;
    }
    private void Update()
    {
       
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
       
        if (this.gameObject.GetComponent<Renderer>().material.color == MoveBlock02.GetComponent<Renderer>().material.color)
        {
            aura02.SetActive(true);
        }
    }

}
