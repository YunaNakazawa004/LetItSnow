using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallManager : MonoBehaviour
{
    bool bEnemy;
    public int nCoolTime = 240;  // 自動発射の場合、何フレームに一回発射するか
    public ScoreManager Score;
    private int nCountCT = 0;    // 発射のカウンター
    public EffectManager EM;
    //GameObject PlayerManager;

    public void Shoot(Vector3 dir, bool b)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        bEnemy = b;
        //GetComponent<ParticleSystem>().Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && bEnemy == false)
        {// プレイヤーの弾が敵に当たった
            Destroy(gameObject);

            //this.PlayerManager = GameObject.Find("PlayerManager");
            //PlayerManager.GetComponent<PlayerManager>().AddScore(1);

            //GetComponent<ParticleSystem>().Play();
            EM.OnBallHit(gameObject);
            Score.UpScore("Enemy", 1);
        }
        else if (other.gameObject.CompareTag("Player") && bEnemy == true)
        {// 敵の弾がプレイヤーに当たった
            EM.OnBallHit(gameObject);
            Destroy(gameObject);

            //GetComponent<ParticleSystem>().Play();
        }
        else if(!other.gameObject.CompareTag("Player") && !other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Score.UpScore("Player", 1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
