using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.AI;

public class JoyStick1 : MonoBehaviour
{

    public GameObject AttachJoyStickSprite, AttachJoyStickBackSprite;
    public Camera AttachGUICamera;

    private Vector2 _position;
    public Vector2 Position
    {
        get { return _position; }
    }

    public  float MaxRadius;
    private const float MAX_RADIUS_RATE = 0.55f;

    //=================================================================================
    //初期化
    //=================================================================================

    private void Awake()
    {
        _position = Vector2.zero;
        //_maxRadius = AttachJoyStickBackSprite.GetComponent<UISprite>().height * MAX_RADIUS_RATE;
    }

    //=================================================================================
    //更新
    //=================================================================================

    private void Update()
    {
        DisplayConfirmation();
        Move();
    }

    //ジョイスティックの表示確認
    private void DisplayConfirmation()
    {

        if (Input.GetMouseButtonDown(0))
        {
            AttachJoyStickBackSprite.SetActive(true);

            AttachJoyStickBackSprite.transform.position = AttachGUICamera.ScreenToWorldPoint(Input.mousePosition);
            AttachJoyStickSprite.transform.position = Vector3.zero;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            AttachJoyStickBackSprite.SetActive(false);
            _position = Vector2.zero;
        }

    }

    //ジョイスティックをタッチされている場所に伴って移動
    private void Move()
    {

        //表示されていなければ移動しない
        if (!AttachJoyStickBackSprite.activeSelf)
        {
            return;
        }

        Vector3 touchPosition = AttachGUICamera.ScreenToWorldPoint(Input.mousePosition);
        AttachJoyStickSprite.transform.position = touchPosition;

        //半径が制限を超えてる場合は制限内に抑える
        float radius = Vector3.Distance(Vector3.zero, AttachJoyStickSprite.transform.localPosition);
        if (radius > MaxRadius)
        {

            //角度
            float radian = CalcRadian(
                Vector3.zero,
                AttachJoyStickSprite.transform.localPosition
            );

            Vector3 setVec = Vector3.zero;
            setVec.x = MaxRadius * Mathf.Cos(radian);
            setVec.y = MaxRadius * Mathf.Sin(radian);

            AttachJoyStickSprite.transform.localPosition = setVec;
        }

        //-1〜1に正規化
        _position = new Vector2(
            AttachJoyStickSprite.transform.localPosition.x / MaxRadius,
            AttachJoyStickSprite.transform.localPosition.y / MaxRadius
        );

    }

    //2点間の角度を求める
    private float CalcRadian(Vector3 from, Vector3 to)
    {
        float dx = to.x - from.x;
        float dy = to.y - from.y;
        float radian = Mathf.Atan2(dy, dx);
        return radian;
    }

}