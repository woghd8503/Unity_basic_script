using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjects : MonoBehaviour
{
    public Person1 man;
    public Person1 woman;

    
    void Start()
    {
        man = new Person1();
        man.firstName = "Greg";
        man.lastName = "Lukosek";

        woman = new Person1();
        woman.firstName = "Kate";
        woman.lastName = "Lukosek";

        man.spouse = woman;
        woman.spouse = man;
       
        if (man.IsMarriedWith(woman))
        {
            Debug.Log(man.firstName + " is married to " + woman.firstName);
        }
        else
        {
            Debug.Log(man.firstName + " and " + woman.firstName + " are not married ");
        }
    }
}

// Person 객체의 인스턴스를 두 개 만들고, 만들어진 인스턴스를 상대방의 퍼블릭 멤버인
// spous에 서로 대입해서 교차 참조 cross-reference 한 뒤에 객체의 메소드를 호출한다.
// 헛갈리지 않게 차근차근 살펴보자.

// 먼저 Person 클래스를 살펴보자. 객체의 개념과 객체 안에 변수를 저장할 수 있다는 점을
// 잘 알고 있을 테니 IsMarriedWith 메소드를 위주로 설명한다. 보시다시피 이 메소드는 하나의
// 파라미터를 받고 bool 값을 리턴 형식 메소드다. 파라미터의 형식에 주목하라. IsMarriedWith 
// 메소드는 Person 클래스의 다른 인스턴스를 파라미터로 받는다.