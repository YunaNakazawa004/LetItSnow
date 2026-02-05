using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallGenerator : MonoBehaviour
{
    public GameObject snowballPrefab;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 shootPos = player.transform.position + Vector3.up * 2.0f; // ì™ÇÃçÇÇ≥
            shootPos += player.transform.forward * 1.5f; // ëÃÇÃëO

            GameObject snowball = Instantiate(snowballPrefab, shootPos, Quaternion.identity);

            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            Vector3 worldDir = ray.direction;
            snowball.GetComponent<SnowBallManager>().Shoot(worldDir.normalized * 2000);
        }
    }
}
