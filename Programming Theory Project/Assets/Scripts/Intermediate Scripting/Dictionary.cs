using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        //This is how you create a Dictionary. Notice how this takes
        //two generic terms. In this case you are using a string and a
        //BadGuy as your two values.
        Dictionary<string, ItemForLorD> badguys = new Dictionary<string, ItemForLorD>();

        ItemForLorD bg1 = new ItemForLorD("Harvey", 50);
        ItemForLorD bg2 = new ItemForLorD("Magneto", 100);

        //You can place variables into the Dictionary with the
        //Add() method.
        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        ItemForLorD magneto = badguys["mutant"];

        ItemForLorD temp = null;

        //This is a safer, but slow, method of accessing
        //values in a dictionary.
        if (badguys.TryGetValue("birds", out temp))
        {
            //success!
        }
        else
        {
            //failure!
        }
    }
}