using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initScene : MonoBehaviour
{
    public GameObject baseDroid;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 range = new Vector3(10, 10, 10);
        for (int i = 0; i<= 10; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(-range.x, range.x),
                Random.Range(-range.y, range.y),
                Random.Range(-range.z, range.z)
                );
            Instantiate(baseDroid, position, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
