using UnityEngine;
using System.Collections;

public class AddEvent : MonoBehaviour
{
    void OnEnable()
    {
        Events.OnClicked += Teleport;
    }


    void OnDisable()
    {
        Events.OnClicked -= Teleport;
    }


    void Teleport()
    {
        Debug.Log("Teleport!");
    }
}