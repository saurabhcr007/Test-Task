using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tipToShow;
    private float timeToWait = 0.001f;

    public void OnPointerEnter(PointerEventData eventData){
        StopAllCoroutines();
        StopCoroutine(StartTimer());
    }
    public void OnPointerExit(PointerEventData eventData){
        StopAllCoroutines();
        HovertipManager.OnMouseLoseFocus();
    }
    private void ShowMessage(){
        HovertipManager.OnMouseHover(tipToShow, Input.mousePosition);
    }
    private IEnumerator StartTimer(){
        yield return new WaitForSeconds(timeToWait);

        ShowMessage();
    }
}
