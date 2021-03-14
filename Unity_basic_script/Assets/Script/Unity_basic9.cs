using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class Unity_basic9 : MonoBehaviour
{
    // 배열 대신 리스트를 사용하면 스크립트 작성이 훨씬 수월하다. 굳이 배열이 꼭
    // 필요한 상황이 아니면 리스트를 사용하는 프로그래머가 많다. 물론 개발자의 취향이나 작업의
    // 성격에 따라 다를 수 있다. 일단 리스트로 밀고 나가보자.
    // 1. 배열의 크기는 바꿀 수 없다.
    // 2. 리스트의 크기는 바꿀 수 있다.
    // 3. 리스트는 요소를 추가하거나 삭제하기 쉽다.
    // 4. 배열의 요소의 수는 늘리려면 원하는 만큼 요소의 수를 늘려서 배열을 새로 만들고 기존
    //    요소를 모두 복사하는 과정을 거쳐야 한다.

    public List<string> familyMembers = new List<string>();

    void Start()
    {
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        string thirdFamilyMember = familyMembers[2];
        Debug.Log(thirdFamilyMember);
    }
    // 여러 문서에서 리스트의 형식을 List<T>로 표시하고 있다. 여기서 T는 데이터 형식을 
    // 나타 낸다. 즉 T의 자리에 모든 형식을 넣을 수 있으며 T형식의 리스트가 만들어진다는
    // 뜻이다. 앞으로는 이 리스트 형식을 사용한다.

    // List<T>는 매우 사용하기 쉽다. 수행할 수 있는 연산도 엄청나게 많다. 이미 리스트의
    // 맨 뒤에 요소를 추가하는 연산을 소개했다. 앞으로 사용할 가능성이 큰 기본적인 연산에
    // 관해 간단하게 살펴보자.
    // 1. Add: List<T>의 맨 뒤에 객체를 추가한다.
    // 2. Remove: List<T>에서 지정한 객체와 처음으로 일치하는 객체를 삭제한다.
    // 3. Clear: List<T>의 모든 요소를 삭제한다.
    // 4. Contains: 지정한 요소가 List<T>안에 있는지 알아낸다. 리스트 안에 원하는 요소가
    //              들어있는지 확인할 때 매우 유용하다.
    // 5. Insert: List<T>의 지정한 인덱스 위치에 요소를 삽입한다.
    // 6. ToArray: List<T>의 요소를 새로운 배열로 복사한다.
    // 배열이 리스트보다 처리 속도가 빠르다. 하지만 리스트는 유연성을 자랑한다. 

    // 배열의 크기는 arrayName.Length: 배열의 크기를 정숫값으로 리턴한다.
    // 리스트의 크기는 listName.Count: 리스트의 크기를 정숫값으로 리턴한다.
    void Update()
    {
        
    }
}
