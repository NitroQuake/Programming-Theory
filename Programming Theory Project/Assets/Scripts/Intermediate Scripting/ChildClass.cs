using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ChildClass : ParentClass
{
    //This is the first constructor for the Apple class.
    //It calls the parent constructor immediately, even
    //before it runs.
    public ChildClass()
    {
        //Notice how Apple has access to the public variable
        //color, which is a part of the parent Fruit class.
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    //This is the second constructor for the Apple class.
    //It specifies which parent constructor will be called
    //using the "base" keyword.
    public ChildClass(string newColor) : base(newColor)
    {
        //Notice how this constructor doesn't set the color
        //since the base constructor sets the color that
        //is passed as an argument.
        Debug.Log("2nd Apple Constructor Called");
    }

    //-

    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }

    //-

    public override void Choppy()
    {
        base.Choppy();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHelloy()
    {
        base.SayHelloy();
        Debug.Log("Hello, I am an apple.");
    }
}
