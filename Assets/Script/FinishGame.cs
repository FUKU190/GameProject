using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public GameObject joyStick;
    public Text Goaltext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            joyStick.transform.position = new Vector2(1200, 120);
            Goaltext.text = "Finish!!!!!!";

        }
    }
}
