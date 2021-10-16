using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    public Button button;
    private bool clicked;

    public IEnumerator CloseOnClick(Action doAfterClick)
    {
        yield return new WaitUntil(() => clicked);

        WaitForEndOfFrame wait = new WaitForEndOfFrame();

        if (!clicked)
        {
            yield return wait;
        }

        clicked = false;
        Debug.Log("Button Clicked");
        Resources.FindObjectsOfTypeAll<TextPanel>()[0].gameObject.SetActive(false);
        doAfterClick();
    }

    public void Clicked()
    {
        clicked = true;
    }
    public void HideText()
    {
        Debug.Log("Hide the text");
    }
}
