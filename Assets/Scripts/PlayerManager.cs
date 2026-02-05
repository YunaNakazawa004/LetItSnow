using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    int nScore;
    public GameObject scoreText;    // スコアの UI

    // Start is called before the first frame update
    void Start()
    {
        // スコアの初期化
        nScore = 0;
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // スコアの加算処理
    public void AddScore(int nValue)
    {
        nScore += nValue;
        SetText();
    }

    void SetText()
    {
        // スコアの表示を更新
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + nScore.ToString();
    }
}
