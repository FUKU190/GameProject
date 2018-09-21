using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{

    NavMeshAgent agent = null;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // 入力を取得
        var v1 = CrossPlatformInputManager.GetAxis("Vertical");
        var h1 = CrossPlatformInputManager.GetAxis("Horizontal");

       
        // スティックが倒れていれば、移動
        if (h1 != 0 || v1 != 0)
        {
            var direction = new Vector3(h1, 0, v1);
            agent.Move(direction * Time.deltaTime);
        }
    }
}