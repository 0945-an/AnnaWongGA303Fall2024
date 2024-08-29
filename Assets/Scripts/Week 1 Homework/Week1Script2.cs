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
    public double total = 0;
    public float floatType = 3.14f;
    public double doubleType = 3.1415;


    void Start()
    {
        Debug.Log($"Starting total is = {total}");
        total = total + intType;
        Debug.Log($"added int ({intType}) to total, making total = {total}");

        Debug.Log($"Total after adding = {total}");
        total = total - longType;
        Debug.Log($"subtracted float ({longType}) to total, making total = {total}");

        Debug.Log($"Total after subtracting = {total}");
        total = total * floatType;
        Debug.Log($"multiplied float ({floatType}) to total, making total = {total}");

        Debug.Log($"Total after multiplying = {total}");
        total = total / doubleType;
        Debug.Log($"divided double ({doubleType}) to total, making total = {total}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
