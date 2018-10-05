using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MyScript : MonoBehaviour
{

    protected Joystick joystick;
    protected JoyButton joyButton;
    public float speed;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<JoyButton>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * speed,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * speed);

        if (joystick.Horizontal != 0 && joystick.Vertical != 0)
        {
            animator.SetBool("Run", true);
            animator.SetBool("Wate", false);
            var direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
            transform.localRotation = Quaternion.LookRotation(direction);
        }
        else if (joystick.Horizontal == 0 && joystick.Vertical == 0)
        {
            animator.SetBool("Run", false);
            animator.SetBool("Wate", true);
        }
    }
}
