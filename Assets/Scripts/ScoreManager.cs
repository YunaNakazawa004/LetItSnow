using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text playerScoreText;    // プレイヤーのスコアテキスト
    public Text enemyScoreText;     // 敵のスコアテキスト

    public int nScorePlayer;       // プレイヤーのスコア
    public int nScoreEnemy;        // 敵のスコア

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
        playerScoreText.text = "PLAYER\n" + nScorePlayer.ToString();    // 整数を文字列に変換
        enemyScoreText.text = "ENEMY\n" + nScoreEnemy.ToString();       // 整数を文字列に変換

#if false
        // 入力テスト
        if(Input.GetMouseButtonDown(1))
        {// 左が押された

            // プレイヤーのスコアの加算
            UpScore("player",1);
        }
        if (Input.GetMouseButtonDown(0))
        {// 右が押された
            
            // 敵のスコアの加算
            UpScore("enemy",1);
        }
#endif
    }

    //========================================
    // スコアの更新処理処理
    //========================================
    public void UpScore(string tag, int nUpScore)
    {
        if(Equals(tag, "player"))
        {// 当たったのがプレイヤー

            nScoreEnemy += nUpScore;      // 敵のスコアを加算
        }
        else if(Equals(tag, "enemy"))
        {// 当たったのが敵

            nScorePlayer += nUpScore;      // プレイヤーのスコアを加算
        }
    }

}

