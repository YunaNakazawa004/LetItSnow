using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallGenerator : MonoBehaviour
{
    public GameObject snowballPrefab;
    public GameObject player;
    public GameObject enemy;
    public bool bEnemy;         // 敵かどうか(敵なら自動で弾を発射)
    public int nCoolTime = 180;  // 自動発射の場合、何フレームに一回発射するか
    private int nCountCT = 0;   // 発射のカウンター

    // Start is called before the first frame update
    void Start()
    {
        nCountCT = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(bEnemy == true)
        {// 敵
            nCountCT++;

            if(nCountCT % nCoolTime == 0)
            {// 一定時間経過
                Vector3 shootPos = enemy.transform.position + Vector3.up * 2.0f; // 頭の高さ
                shootPos += enemy.transform.forward * 1.5f; // 体の前

                GameObject snowball = Instantiate(snowballPrefab, shootPos, Quaternion.identity);

                Ray ray = Camera.main.ViewportPointToRay(player.transform.position);
                //Vector3 worldDir = -ray.direction;
                Vector3 worldDir = player.transform.position - enemy.transform.position;
                snowball.GetComponent<SnowBallManager>().Shoot(worldDir.normalized * 2000);
            }
        }
        else
        {// プレイヤー
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 shootPos = player.transform.position + Vector3.up * 2.0f; // 頭の高さ
                shootPos += player.transform.forward * 1.5f; // 体の前

                GameObject snowball = Instantiate(snowballPrefab, shootPos, Quaternion.identity);

                Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                Vector3 worldDir = ray.direction;
                snowball.GetComponent<SnowBallManager>().Shoot(worldDir.normalized * 2000);
            }
        }
    }
}
