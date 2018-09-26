using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
                                //vvvvvvvvv laat je script van interactable inheriten!
public class ClickableExample : Interactable {

    public int ClickAmount;
    public Text Label;


	// Use this for initialization
    protected override void Click()
    {
        ClickAmount++;
        Label.text = "Aantal Clicks: " + ClickAmount;
    }
}
