using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTap6 : MonoBehaviour
{
    int TouchNum6, checknum6;
    public GameObject MoveBlock06, Aura06;

    // Start is called before the first frame update
    void Start()
    {
        Aura06.SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
        
    }

    void OnCollisionEnter(Collision col06)
    {
        if (col06.gameObject.tag == "Player")
        {
            Aura06.SetActive(true);
            GameObject.Find("MoveBlock").GetComponent<MoveBlock>().PanelNum++;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
