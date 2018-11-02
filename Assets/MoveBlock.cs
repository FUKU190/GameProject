using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MoveBlock : MonoBehaviour
{
    public Rigidbody rb;
    public float upspeed;
    public float posision;
    Vector3 force;
    public GameObject player;

    void Start()
    {
        upspeed = 0;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void Update()
    {
        rb.velocity = new Vector3(0, upspeed, 0);

        if (this.gameObject.transform.position.y > posision)
        {
            upspeed = 0;
            rb.isKinematic = true;
        }
        else if(this.gameObject.transform.position.y > posision - 3)
        {
            upspeed = 2.5f;
        }
        if(this.gameObject.transform.position.y >= 160)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        if (this.gameObject.transform.position.y >= 140)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (this.gameObject.transform.position.y >= 120)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (this.gameObject.transform.position.y >= 100)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (this.gameObject.transform.position.y >= 80)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
        else if (this.gameObject.transform.position.y >= 60)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (this.gameObject.transform.position.y >= 40)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (this.gameObject.transform.position.y >= 20)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine("UpFloor");
        }
    }

    IEnumerator UpFloor()
        {
            yield return new WaitForSeconds(0.5f);
            rb.isKinematic = false;
            upspeed = 4;
            yield return null;
        }
    }
