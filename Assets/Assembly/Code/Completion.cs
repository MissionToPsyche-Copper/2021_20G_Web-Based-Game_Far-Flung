using System;
using System.Collections;
using System.Collections.Generic;
using Codice.Client.GameUI.Explorer;
using UnityEngine;

public class Completion : MonoBehaviour
{
    public void CheckCompletion()
    {
        foreach (Transform child in transform)
        {
            //Implement completion check
            if (child != null && child.GetComponent<DropSlot>() != null)
            {
                bool slotCompleted = child.GetComponent<DropSlot>().IsCompleted();
                Debug.Log(child.name + " is " + slotCompleted);
                if (!slotCompleted)
                {
                    return;
                }
            }
            
        }
        // GameObject textPanel = Resources.FindObjectsOfTypeAll<TextPanel>()[0].gameObject;
        // textPanel.SetActive(true);
        // StartCoroutine(textPanel.GetComponent<TextPanel>().button.GetComponent<ButtonFunctions>().CloseOnClick(() => Debug.Log("All Slots Completed")));
    }
}
