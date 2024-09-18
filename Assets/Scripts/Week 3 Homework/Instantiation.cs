using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject InstantiatePrefab;
    public Transform otherSpawnLocation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameObject prefabCube = Instantiate(InstantiatePrefab, this.transform.position, this.transform.rotation);
            
        }
    }
}
