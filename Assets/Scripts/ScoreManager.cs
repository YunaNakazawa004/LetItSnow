using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text playerScoreText;    // プレイヤーのスコアテキスト
    public Text enemyScoreText;     // 敵のスコアテキスト

    private int nScorePlayer;       // プレイヤーのスコア
    private int nScoreEnemy;        // 敵のスコア

    //=====================================================
    // 開始処理
    //=====================================================
    void Start()
    {
        nScorePlayer = 0;   // プレイヤーのスコアを初期化
        nScoreEnemy = 0;    // 敵のスコアを初期化
    }

    //=====================================================
    // 更新処理
    //=====================================================
    void Update()
    {
        // 表示テキストの設定
        playerScoreText.text = "PLAYER\n" + nScorePlayer;
        enemyScoreText.text = "ENEMY\n" + nScoreEnemy;
    }

    //========================================
    // スコアの更新処理処理
    //========================================
    void UpScore(string tag)
    {
        if(Equals(tag, "player"))
        {// 当たったのがプレイヤー

            nScoreEnemy++;      // 敵のスコアを加算
        }
        else if(Equals(tag, "enemy"))
        {// 当たったのが敵

            nScorePlayer++;      // プレイヤーのスコアを加算
        }
    }

}

