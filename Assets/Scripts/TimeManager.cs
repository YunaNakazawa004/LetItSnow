using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public ScoreManager GetScoreScript;

    public Text timeText;    //時間表示用テキスト
    public float limit = 180.0f;    //制限時間
    public GameObject text;    //ゲームセット表示用テキスト
    private bool isGameSet = false;    //ゲームセット判定

    void Start()
    {
        timeText.text = "TIME\n" + limit + " s";
    }

    void Update()
    {
        //ゲームオーバー状態で画面がクリックされたとき
        if (isGameSet && Input.GetMouseButton(0))
        {
            Restart();
        }

        //時間制限がきたとき
        if (limit < 0)
        {
            if (GetScoreScript.nScorePlayer > GetScoreScript.nScoreEnemy)
            {// プレイヤーのスコアが高い場合

                //ゲームセットを表示する
                text.GetComponent<Text>().text = "GameSet!\n" + "YOU WIN!!\n" + "\nPrease Buttton";
            }
            else if(GetScoreScript.nScorePlayer == GetScoreScript.nScoreEnemy)
            {
                //ゲームセットを表示する
                text.GetComponent<Text>().text = "GameSet!\n" + "DROW\n" + "\nPrease Buttton";
            }
            else
            {
                //ゲームセットを表示する
                text.GetComponent<Text>().text = "GameSet!\n" + "YOU LOSE...\n" + "\nPrease Buttton";
            }

            text.SetActive(true);
            isGameSet = true;            //ゲームオーバー
            return;
        }

        //時間をカウントダウンする
        limit -= Time.deltaTime;
        timeText.text = "TIME\n" + limit.ToString("f2") + " s";
    }

    //シーンを再読み込みする
    private void Restart()
    {
        // 現在のScene名を取得する
        Scene loadScene = SceneManager.GetActiveScene();
        // Sceneの読み直し
        SceneManager.LoadScene(loadScene.name);
    }
}