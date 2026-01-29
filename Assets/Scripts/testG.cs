using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testG : MonoBehaviour
{
    public GameObject ParticlePrehab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(ParticlePrehab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            igaguri.GetComponent<testC>().Generate();
        }
    }
}
