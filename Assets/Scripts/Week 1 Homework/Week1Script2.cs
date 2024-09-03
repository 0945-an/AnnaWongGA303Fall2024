using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Schema;
using UnityEngine;

public class Week1Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Number Variables
    public int intType = 182;
    public long longType = 52975738;
    public float floatType = 3.14f;
    public double doubleType = 3.1415;

    public double total = 0;
    public double total2 = 0;
    public double total3 = 0;
    public double total4 = 0;


    void Start()
    { 
        Debug.Log($"Starting total is = {total}");
        total = total + intType;
        Debug.Log($"added int ({intType}) to total, making total = {total}");
        total = total + floatType;
        Debug.Log($"added float ({floatType}) to total, making total = {total}");
        total = total + doubleType;
        Debug.Log($"added double ({doubleType}) to total, making final total = {total}");

        Debug.Log($"Starting total is = {total2}");
        total2 = total2 - longType;
        Debug.Log($"subtracted float ({longType}) to total, making total = {total2}");
        total2 = total2 - doubleType;
        Debug.Log($"subtracted double ({doubleType}) total, making total = {total2}");
        total2 = total2 - intType;
        Debug.Log($"subtracted int ({intType}) to total, making final total = {total2}");

        Debug.Log($"Starting total is = {total3}");
        total3 = total3 * floatType;
        Debug.Log($"multiplied float ({floatType}) to total, making total = {total3}");
        total3 = total3 * intType;
        Debug.Log($"multiplied int ({intType}) to total, making total = {total3}");
        total3 = total3 * longType;
        Debug.Log($"multiplied long ({longType}) to total, making final total = {total3}");

        Debug.Log($"Starting total is = {total4}");
        total4 = total4 / doubleType;
        Debug.Log($"divided double ({doubleType}) to total, making total = {total4}");
        total4 = total4 / doubleType;
        Debug.Log($"divided int ({intType}) to total, making total = {total4}");
        total4 = total4 / doubleType;
        Debug.Log($"divided float ({floatType}) to total, making final total = {total4}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
