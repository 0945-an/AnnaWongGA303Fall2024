using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Week1Script3: MonoBehaviour
{
    // Start is called before the first frame update

    public string beginningString;
    public string middleString;
    public string endingString;
    void Start()
    {
        beginningString = "Once upon a time, there was an ugly barnacle, ";
        middleString = "he was so ugly that everyone died, ";
        endingString = "The end.";
        Debug.Log(beginningString + middleString + endingString);
    }

    public void Function(string s1, string s2, string s3)
    {
        beginningString = s1;
        middleString = s2;
        endingString = s3;
        Debug.Log(beginningString + middleString + endingString);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
