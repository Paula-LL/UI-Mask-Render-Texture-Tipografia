using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class FillPhial : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //public RectTransform healthBarLiquid;
    public bool buttonPressed;
    public Image hpLiquid; 

    float timer = 0;
    float waitTime = 60; 

    public void OnPointerDown(PointerEventData eventData)
    {
            //OnButtonHeld(10);
            buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    private void Update()
    {
        if (buttonPressed == true)
        {
            timer += Time.deltaTime;
            hpLiquid.fillAmount += 1.0f / (waitTime * timer);
        }
    }

    /*public void OnButtonHeld(int fill) {
        healthBarLiquid.sizeDelta = new Vector2(fill, 41.07f);  
        //healthBarLiquid.transform.position = Vector3 (-92f, 0, 0, Space.Self); 
    }*/
}
