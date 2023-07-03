using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI screenText;
    private string shapeName { get; set; } //ENCAPSULATION

    private void OnMouseDown()
    {
        shapeName = "Shape";
        Talk(); //ABSTRACTION
    }

    protected virtual void Talk()
    {
        screenText.text = shapeName + " saying 'Hello' to you";
    }
}
