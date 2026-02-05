using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallManager : MonoBehaviour
{
    bool bEnemy;
    //GameObject PlayerManager;

    public void Shoot(Vector3 dir, bool b)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        bEnemy = b;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy") && bEnemy == false)
        {// ƒvƒŒƒCƒ„[‚Ì’e‚ª“G‚É“–‚½‚Á‚½
            Destroy(gameObject);

            //this.PlayerManager = GameObject.Find("PlayerManager");
            //PlayerManager.GetComponent<PlayerManager>().AddScore(1);

            //GetComponent<ParticleSystem>().Play();
        }

        if (other.gameObject.CompareTag("Player") && bEnemy == true)
        {// “G‚Ì’e‚ªƒvƒŒƒCƒ„[‚É“–‚½‚Á‚½
            Destroy(gameObject);

            //GetComponent<ParticleSystem>().Play();
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
