using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape //INHERITANCE
{
    protected override void Talk() //POLYMORPHISM
    {
        screenText.text = "Hello! Im Cylinder.";
    }
}
