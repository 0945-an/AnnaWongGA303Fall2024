using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Week1Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Number Variables
    public int intType = 182;
    public long longType = 52975738;
    public double doubleType = 2;
    public float floatType = 2.42f;
    public float totalType = 0;


    void Start()
    {
        Debug.Log("Starting total is" + intType);
        totalType = totalType + intType;
        Debug.Log("added" + intType + "to total, making total" + totalType);
        Debug.Log("added" + longType + "total adding long");
        totalType = totalType + intType + longType;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
