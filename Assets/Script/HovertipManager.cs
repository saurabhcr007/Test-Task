using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HovertipManager : MonoBehaviour
{
    public TextMeshProUGUI tipText;
    public RectTransform tipWindow;
    public static Action <string, Vector2> OnMouseHover;
    public static Action OnMouseLoseFocus;

    private void OnEnable() {
        OnMouseHover += ShowTip;
        OnMouseLoseFocus += HideTip;
    }
    private void OnDisable() {
        OnMouseHover -= ShowTip;
        OnMouseLoseFocus -= HideTip;
    }
    // Start is called before the first frame update
    void Start()
    {
        tipText.text = default;
        tipWindow.gameObject.SetActive(false);
    }
    private void ShowTip(String tip, Vector2 mousePos){
        tipText.text = tip;
        tipWindow.sizeDelta = new Vector2(tipText.preferredWidth > 200 ? 200 : tipText.preferredWidth, tipText.preferredHeight);
        tipWindow.gameObject.SetActive(true);
        tipWindow.transform.position = new Vector2(mousePos.x + tipWindow.sizeDelta.x * 2, mousePos.y);
    }
    private void HideTip(){
        tipText.text = default;
        tipWindow.gameObject.SetActive(false);
    }
}
