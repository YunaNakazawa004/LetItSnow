using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testG : MonoBehaviour
{
    public GameObject ParticlePrehab = null;
    public GameObject ParticlePrehab2 = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //if (Input.GetMouseButtonDown(0))
        {
            // マウスの位置を取得
            Vector3 mousePos = Input.mousePosition;

            mousePos.z = 10f;

            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);

            if (ParticlePrehab != null)
            {
                Instantiate(ParticlePrehab, spawnPos, Quaternion.identity);
            }
            if (ParticlePrehab2 != null)
            {
                Instantiate(ParticlePrehab2, spawnPos, Quaternion.identity);
            }

            // ParticlePrehab.GetComponent<testC>().OnParticle();
        }
    }
}
