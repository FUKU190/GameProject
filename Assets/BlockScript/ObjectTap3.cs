using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap3 : MonoBehaviour
{
    public GameObject Aura03;

    // Start is called before the first frame update
    void Start()
    {
        Aura03.SetActive(false);
    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col02)
    {
        Aura03.SetActive(true);
        GameObject.Find("MoveBlock").GetComponent<MoveBlock>().PanelNum++;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
