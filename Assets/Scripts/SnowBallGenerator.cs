using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallGenerator : MonoBehaviour
{
    public GameObject snowballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject snowball = Instantiate(snowballPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            snowball.GetComponent<SnowBallManager>().Shoot(worldDir.normalized * 2000);
        }
    }
}
