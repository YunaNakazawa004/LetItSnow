using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public GameObject EffectPrefab;
    private Dictionary<GameObject, GameObject> trails = new Dictionary<GameObject, GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // シーン上の全ての玉を検索
        //var balls = GameObject.FindGameObjectsWithTag("Ball");

        //foreach (var ball in balls)
        //{
        //    if (EffectPrefab != null)
        //    {
        //        // エフェクト付与
        //        GameObject effect = Instantiate(EffectPrefab, ball.transform);
        //        effect.transform.localPosition = Vector3.zero;
        //    }

        //}
    }
}
