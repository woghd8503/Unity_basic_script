using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person2 : MonoBehaviour
{
    public string firstName = "";
    public string lastName = "";
    public Person2 spouse;

    // 정의 생성자 custom constructor를 사용하지 않는 C# 객체는 모두 암묵적 생성자를 사용

    // 퍼블릭 생성자의 문법은 항상 public으로 시작하고 클래스 이름을 적은 뒤에 괄호를 추가하고
    // 괄호 안에 넣고 싶은 파라미터를 넣는다.
    public Person2()
    {

    }

    public Person2(string pFirstName, string pLastName)
    {
        this.firstName = pFirstName;
        this.lastName = pLastName;
    }

    public bool IsMarriedWith(Person2 otherPerson)
    {
        if (spouse != null)
        {
            //Person object is stored in spouse varible
            if (otherPerson == this.spouse)
            {
                //OtherPerson object is the same as stored spouse
                return true;
            }
            else
            {
                //not married
                return false;
            }
        }
        else
        {
            //spouse variable is not assigned so this
            //Person is not married at all
            return false;
        }
    }
}
