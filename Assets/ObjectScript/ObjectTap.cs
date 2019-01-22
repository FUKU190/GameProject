using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTap : MonoBehaviour {

    public GameObject Aura01;
    public MoveBlock Move1;

    // Start is called before the first frame update
    void Start()
    {
        Aura01.SetActive(false);
    }

    void OnCollisionEnter(Collision col01)
    {
        Move1.PanelNum++;
        Aura01.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
