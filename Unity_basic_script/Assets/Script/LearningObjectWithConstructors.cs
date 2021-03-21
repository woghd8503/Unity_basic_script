using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjectWithConstructors : MonoBehaviour
{
    public Person2 man;
    public Person2 woman;
   
    void Start()
    {
        man = new Person2("Greg", "Lukosek");
        woman = new Person2("Kate", "Lukosek");

        man.spouse = woman;
        woman.spouse = man;

        if(man.IsMarriedWith(woman))
        {
            Debug.Log(man.firstName + " is married to " + woman.firstName);
        }
        else
        {
            Debug.Log(man.firstName + " and " + woman.firstName + " are not married ");
        }
    }
}
