using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Maincamera;
    public bool flg = true;
    public FollowPlayer follow;

    public void OnClick()
    {
        if (!flg)
        {
            follow.offset.y = follow.offset.y - 5.41f;
            follow.offset.z = follow.offset.z + 1.95f;
            Maincamera.transform.Rotate(-30, 0, 0);
            flg = true;
        }
        else if (flg)
        {
        
            follow.offset.y = follow.offset.y + 5.41f;
            follow.offset.z = follow.offset.z - 1.95f;
            Maincamera.transform.Rotate(30, 0, 0);
            flg = false;
        }
    }
}
