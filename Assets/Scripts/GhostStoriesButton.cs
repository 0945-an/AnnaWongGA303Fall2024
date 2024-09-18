using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GhostStoriesButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text StartButtonText;
    public Color MouseOverColor;
    public Color MouseOutColor;
    public string StartingString;
    public string EndingString;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StartButtonText.color = MouseOverColor;
        StartButtonText.text = StartingString;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartButtonText.color = MouseOutColor;
        StartButtonText.text = EndingString;
    }
}
