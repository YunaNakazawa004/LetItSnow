using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallManager : MonoBehaviour
{
    bool bEnemy;

    public void Shoot(Vector3 dir, bool b)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        bEnemy = b;
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;

        //GetComponent<ParticleSystem>().Play();

        // ぶつかったオブジェクトのタグがプレイヤーか敵なら
        if(other.gameObject.CompareTag("Enemy") && bEnemy == false)
        {// プレイヤーの弾が敵に当たった
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Player") && bEnemy == true)
        {// 敵の弾がプレイヤーに当たった
            Destroy(gameObject);
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
