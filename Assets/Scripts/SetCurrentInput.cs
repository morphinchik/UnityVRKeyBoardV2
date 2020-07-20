using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class SetCurrentInput : MonoBehaviour , ISelectHandler
{
    public CurrentInput thisInputsArea = null;

      
     public void OnSelect (BaseEventData eventData) 
	{
        thisInputsArea.currentField = this.GetComponent<InputField>();
    }
}
