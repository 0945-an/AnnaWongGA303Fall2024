using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject publicObject;

    void Start()
    {
        Week1Script3 script = publicObject.GetComponent<Week1Script3>();
        script.Function("From where I stand, ", "society's ideal system should be ", "seven rest days.");
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
