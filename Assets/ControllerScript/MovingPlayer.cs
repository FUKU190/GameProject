using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingPlayer : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;

    Animator animator;
    //移動速度
     public float SPEED = 0;

    private void Start()
    {
        _joystick = FindObjectOfType<Joystick>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos.x += _joystick.Position.x * SPEED;
        pos.z += _joystick.Position.y * SPEED;

        transform.position = pos;
        if(_joystick.Position.x != 0 && _joystick.Position.y != 0)
        {
            SPEED = 0.08f;
            animator.SetBool("Run",true);
            animator.SetBool("Wate", false);
            var direction = new Vector3(_joystick.Position.x, 0, _joystick.Position.y);
            transform.localRotation = Quaternion.LookRotation(direction);
        }
        else if(_joystick.Position.x == 0 && _joystick.Position.y == 0) 
        {
            SPEED = 0;
            animator.SetBool("Run", false);
            animator.SetBool("Wate", true);
        }
        animator.SetBool("Wate", true);
    }
}
