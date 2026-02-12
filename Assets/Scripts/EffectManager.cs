using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public GameObject EffectPrefab;
    public GameObject EffectPrefab2;
    public GameObject EffectPrefab3;
    private Dictionary<GameObject, GameObject> trails = new Dictionary<GameObject, GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // シーン上の全ての玉を検索
        var balls = GameObject.FindGameObjectsWithTag("Ball");

        foreach (var ball in balls)
        {
            Debug.Log("effected!");
            if (EffectPrefab != null)
            {
                // エフェクト付与
                GameObject effect = Instantiate(EffectPrefab, ball.transform);
                effect.transform.localPosition = Vector3.zero;
            }

        }
    }
    public void OnBallHit(GameObject ball)
    {
        if (EffectPrefab2 != null)
        {
            Vector3 spawnPos = ball.transform.position;

            if (EffectPrefab2 != null)
            {
                Instantiate(EffectPrefab2, spawnPos, Quaternion.identity);
            }
        }
        if (EffectPrefab3 != null)
        {
            Vector3 spawnPos = ball.transform.position;

            if (EffectPrefab3 != null)
            {
                Instantiate(EffectPrefab2, spawnPos, Quaternion.identity);
            }
        }
    }

}
