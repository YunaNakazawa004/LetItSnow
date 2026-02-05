using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public GameObject throwPrefab;       // 投げるオブジェクト

    public float fMoveSpeed = 0.0f;      // 移動速度
    public float fRepeatSpeed = 0.0f;    // 反復速度

    private Vector3 startPos;            // 開始位置
    private float fAngle = 0.0f;         // 角度

    //=====================================================
    // 開始処理
    //=====================================================
    void Start()
    {
        startPos = transform.position;  // オブジェクトの初期位置を設定
    }

    //=====================================================
    // 更新処理
    //=====================================================
    void Update()
    {
        //float fRand;

        // 移動(反復)処理
        MoveEnemy();

        if (Input.GetMouseButtonDown(0))
        {// マウスが押された

            // 投げる処理
            ThrowEnemy();
        }
    }

    //========================================
    // 敵の移動処理
    //========================================
    void MoveEnemy()
    {
        float faddPosX = 0.0f;     // 初期位置からずらす量

        fAngle += fRepeatSpeed;    // 角度に反復速度を加算

        // 角度の修正
        if (fAngle >= Mathf.PI)
        {
            fAngle -= Mathf.PI * 2;
        }
        else if (fAngle <= -Mathf.PI)
        {
            fAngle += Mathf.PI * 2;
        }

        // ずらす位置を求める
        faddPosX = Mathf.Sin(fAngle) * fMoveSpeed;

        // オブジェクトの位置を移動
        transform.position = new Vector3(startPos.x + faddPosX, startPos.y, startPos.z);
    }

    //========================================
    // 敵が投げる処理
    //========================================
    void ThrowEnemy()
    {
        GameObject throwItem = Instantiate(throwPrefab);
        

    }
}
