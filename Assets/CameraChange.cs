using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Maincamera;
    public GameObject SubCamera;
    public bool flg = true;
    public FollowPlayer follow;

    // Start is called before the first frame update
    void Start()
    {
        SubCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        if (!flg)
        {
            ////SubCamera.SetActive(true);
            //Maincamera.SetActive(false);
            follow.offset.y = follow.offset.y - 5.41f;
            follow.offset.z = follow.offset.z + 1.95f;
            Maincamera.transform.Rotate(-30, 0, 0);
            flg = true;
        }
        else if (flg)
        {
            //SubCamera.SetActive(false);
            //Maincamera.SetActive(true);
            follow.offset.y = follow.offset.y + 5.41f;
            follow.offset.z = follow.offset.z - 1.95f;
            Maincamera.transform.Rotate(30, 0, 0);
            flg = false;
        }
    }
}
