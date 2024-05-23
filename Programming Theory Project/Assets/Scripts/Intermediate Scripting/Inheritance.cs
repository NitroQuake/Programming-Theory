using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    void Start()
    {
        //-Inheritance

        //Let's illustrate inheritance with the 
        //default constructors.
        Debug.Log("Creating the fruit");
        ParentClass myFruit = new ParentClass();
        Debug.Log("Creating the apple");
        ChildClass myApple = new ChildClass();

        //Call the methods of the Parent class.
        myFruit.SayHello();
        myFruit.Chop();

        //Call the methods of the child class.
        //Notice how class child has access to all
        //of the public methods of class ParentClass.
        myApple.SayHello();
        myApple.Chop();

        //Now let's illustrate inheritance with the 
        //constructors that read in a string.
        Debug.Log("Creating the fruit");
        myFruit = new ParentClass("yellow");
        Debug.Log("Creating the apple");
        myApple = new ChildClass("green");

        //Call the methods of the parent class.
        myFruit.SayHello();
        myFruit.Chop();

        //Call the methods of the child class.
        //Notice how class child has access to all
        //of the public methods of class ParentClass.
        myApple.SayHello();
        myApple.Chop();

        //-Polymorphism

        //Notice here how the variable "myFruitA" is of type
        //ParentClass but is being assigned a reference to an ChildClass. This
        //works because of Polymorphism. Since an ChildClass is a ParentClass,
        //this works just fine. While the ChildClass reference is stored
        //in a ParentClass variable, it can only be used like a ParentClass
        ParentClass myFruitA = new ChildClass();

        myFruitA.SayHello();
        myFruitA.Chop();

        //This is called downcasting. The variable "myFruitA" which is 
        //of type ParentClass, actually contains a reference to an ChildClass. Therefore,
        //it can safely be turned back into an ChildClass variable. This allows
        //it to be used like an ChildClass, where before it could only be used
        //like a ParentC.
        ChildClass myAppleA = (ChildClass)myFruitA;

        myAppleA.SayHello();
        myAppleA.Chop();

        //-Member Hiding

        ParentClass human = new ParentClass();
        ChildClass enemy = new ChildClass();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();

        //-Overriding

        ChildClass myAppleB = new ChildClass();

        //Notice that the ChildClass version of the methods
        //override the ParentClass versions. Also notice that
        //since the ChildClass versions call the ParentClass version with
        //the "base" keyword, both are called.
        myApple.SayHello();
        myApple.Chop();

        //Overriding is also useful in a polymorphic situation.
        //Since the methods of the ParentClass class are "virtual" and
        //the methods of the Apple class are "override", when we 
        //upcast an ChildClass into a ParentClass, the ChildClass version of the 
        //Methods are used.
        ParentClass myFruitB = new ChildClass();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
