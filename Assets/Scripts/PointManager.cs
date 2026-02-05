using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text PointText;    //ポイント表示用テキスト
    public int PlayerPoint = 0;
    public int EnemyPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        PointText.text = "あなた：" + PlayerPoint + "   敵：" + EnemyPoint;
    }

    // Update is called once per frame
    void Update()
    {
        PointText.text = "あなた：" + PlayerPoint + "   敵：" + EnemyPoint;
    }
}
