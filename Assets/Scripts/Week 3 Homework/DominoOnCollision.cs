using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoOnCollision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Domino;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == Domino)
        {
            Debug.Log($"Sphere is hit with {collision.gameObject} and is now moving");
        }

    }
}

