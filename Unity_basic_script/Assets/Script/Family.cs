using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public Person father;
    public Person mother;
    public Person son;
    
    void Start()
    {
        father = new Person();
        father.firstName = "Greg";
        father.lastName = "Lukosek";
        father.age = 29;
        father.isMale = true;
        father.isMarried = true;

        mother = new Person();
        mother.firstName = "Kate";
        mother.lastName = "Lukosek";
        mother.age = 28;
        mother.isMale = false;
        mother.isMarried = true;

        son = new Person();
        son.firstName = "Adam";
        son.lastName = "Lukosek";
        son.age = 3;
        son.isMale = true;
        son.isMarried = false;

        Debug.Log(father.firstName + " and " + mother.firstName + " have a beatiful son "
            + son.firstName);
    }
}

// new 키워드 뒤에 객체의 형식인 objectType을 적고 괄호를 여닫았다. 앞서 설명 했듯이
// objecType은 클래스의 이름이다.
// 객체를 인스턴스화할 때마다 유니티는 메모리에 객체를 저장할 공간을 마련한다.