using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardOnCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Sphere;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == Sphere)
        {
            Debug.Log($"Board is hit with {collision.gameObject} and is launching sphere 3 ");
        }

    }
}
