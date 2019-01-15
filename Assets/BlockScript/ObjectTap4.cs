using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap4 : MonoBehaviour
{
    public GameObject Aura04;

    // Start is called before the first frame update
    void Start()
    {
        Aura04.SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
       
    }
    void OnCollisionEnter(Collision col04)
    {
        if (col04.gameObject.tag == "Player")
        {
            Aura04.SetActive(true);
            GameObject.Find("MoveBlock").GetComponent<MoveBlock>().PanelNum++;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}