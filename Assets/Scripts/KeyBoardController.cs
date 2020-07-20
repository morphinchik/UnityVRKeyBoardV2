using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class KeyBoardController : MonoBehaviour 
{
  
    public void controlKey()
    {
        InputField tempInputField = GetComponentInParent<CurrentInput>().currentField;
      
        if (this.gameObject.name == "BShift")
        {
            print("BShift");
            getLetterUpper();

        } else if (this.gameObject.name == "BBackSpace")
        {
            if (tempInputField.text.Length > 0)
            {
                tempInputField.text = tempInputField.text.Substring(0, tempInputField.text.Length - 1);
            }
            return;
        }
        else if (this.gameObject.name == "BClear")
        {

            tempInputField.text = "";
        }
        else if (this.gameObject.name == "BSpace")
        {
            tempInputField.text += " ";
        }
        else {
            tempInputField.text += this.GetComponentInChildren<TMP_Text>().text;
        }


    }
    public  void getLetterUpper()
    {
        GameObject[] keys = GameObject.FindGameObjectsWithTag("LetterKey");
        
        foreach (var key in keys)
        {
            if (key.GetComponentInChildren<TMP_Text>().text == key.GetComponentInChildren<TMP_Text>().text.ToUpper())
            {
                key.GetComponentInChildren<TMP_Text>().text = key.GetComponentInChildren<TMP_Text>().text.ToLower();
            }
            else
            key.GetComponentInChildren<TMP_Text>().text = key.GetComponentInChildren<TMP_Text>().text.ToUpper();
        }
    }
    
}
