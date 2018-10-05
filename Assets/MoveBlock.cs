using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MoveBlock : MonoBehaviour
{
    public Rigidbody rb;
    public float upspeed;
    public float posision;
    Vector3 force;

    void Start()
    {
        upspeed = 0;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        
    }

    void Update()
    {
       rb.velocity= new Vector3(0, upspeed, 0);
       
        if(this.gameObject.transform.position.y > posision - 3)
        {
            force = new Vector3(0, 0.5f, 0);
            rb.AddForce(force);
        }
        if (this.gameObject.transform.position.y > posision)
        {
            upspeed = 0;
            rb.isKinematic = true;
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
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