using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person1 : MonoBehaviour
{
    public string firstName = "";
    public string lastName = "";
    public Person1 spouse;
    
    public bool IsMarriedWith (Person1 otherPerson)
    {
       if(spouse != null)
        // spous 변수에는 Person 객체가 들어 있다.
        {
            if(otherPerson == this.spouse)
            {
                // otherPerson 객체가 spouse에 들어 있는 객체와 같을 때
                return true;
            }
            else
            {
                // not married
                return false;
            }
        }
        else
        {
            // spouse 변수에 값이 없으므로
            // 이 Person은 미혼이다
            return false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
