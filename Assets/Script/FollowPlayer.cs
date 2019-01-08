using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;    // ターゲットへの参照
    private Vector3 offset;     // 相対座
    int Click;
    [SerializeField]
    private GameObject maincamera;
    [SerializeField]
    private GameObject otherCamera;


    void Start()
    {
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
        //camerapos = mainCamera.transform.position;
    }

    void Update()
    {
        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
        GetComponent<Transform>().position = target.position + offset;
        //GetComponent<Transform>().position = target.position - transform.forward * 2.5f + transform.up * 2;
        //GetComponent<Transform>().rotation = target.rotation;
    }
    public void OnClick()
    {
        if(Click == 0)
        {
            Click = 1;
        }
        else if(Click == 1)
        {
            Click = 0;
        }
        if (Click == 1)
        {
            maincamera.SetActive(false);
            otherCamera.SetActive(true);
        }
        else if(Click == 0)
        {
            maincamera.SetActive(true);
            otherCamera.SetActive(false);
        }
    }
}