using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleNamespace; //Namespace.cs

public class GameManager : MonoBehaviour
{
    public GameObject[] dogs;
    private float posY = 0;
    private float posZ = -31.5f;
    private float startDelay = 3;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomDog", startDelay, repeatRate);

        //-Properties

        Properties myPlayer = new Properties();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int a = myPlayer.Experience;

        //-Static

        int b = Static.playerCount;

        //You can access a static method by using the class name
        //and the dot operator.
        int c = Static.Add(5, 6);

        //-Overloading

        Overloading myClass = new Overloading();

        //The specific Add method called will depend on
        //the arguments passed in.
        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");

        //-Generics

        Generic<int> generic = new Generic<int>();
        generic.UpdateItem(5);

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        generic.GenericMethod<int>(5);

        //-Extension

        //Notice how you pass no parameter into this
        //extension method even though you had one in the
        //method declaration. The transform object that
        //this method is called from automatically gets
        //passed in as the first parameter.
        transform.ResetTransformation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ABSTRACTION
    private void RandomDog()
    {
        float randomX = Random.Range(-58, -49);
        Vector3 positon = new Vector3(randomX, posY, posZ);
        int index = Random.Range(0, dogs.Length);
        Instantiate(dogs[index], positon, transform.rotation);
    }
}
