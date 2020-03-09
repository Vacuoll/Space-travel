using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Resume : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        GameObject.FindGameObjectWithTag("Manager").GetComponent<MenuButtons>().Continue();
    }
    
}
