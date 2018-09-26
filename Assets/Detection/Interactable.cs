using UnityEngine;
using System.Collections;

public abstract class Interactable : MonoBehaviour
{
    bool _clicked;
    float Cooldown = 30; //The amount of frames the interactable should not be hit again
    // Prevents double inputs

    public void Interact()
    {
        if (!_clicked)
        {
            StartCoroutine(_click());
            Click();
        }
    }

    protected virtual void Click()
    {
        throw new System.Exception("Click-Method not implemented!");
    }

    IEnumerator _click()
    {   
        _clicked = true;
        float framecount = Cooldown;
        while (framecount >= 0)
        {
            framecount--;
            yield return null;
        }

        _clicked = false;
    }
}