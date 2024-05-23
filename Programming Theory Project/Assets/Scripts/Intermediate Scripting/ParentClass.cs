using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentClass : MonoBehaviour
{
    public string color;

    //This is the first constructor for the Fruit class
    //and is not inherited by any derived classes.
    public ParentClass()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    //This is the second constructor for the Fruit class
    //and is not inherited by any derived classes.
    public ParentClass(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }

    //-

    //Base version of the Yell method
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }

    //-

    //These methods are virtual and thus can be overriden
    //in child classes
    public virtual void Choppy()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHelloy()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
