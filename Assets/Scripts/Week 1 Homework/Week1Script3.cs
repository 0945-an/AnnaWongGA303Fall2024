using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Week1Script3: MonoBehaviour
{
    // Start is called before the first frame update

    public string beginningString = "Once upon a time, there was an ugly barnacle, ";
    public string middleString = "he was so ugly that everyone died, ";
    public string endingString = "The end.";
    void Start()
    {
        Debug.Log(beginningString + middleString + endingString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
