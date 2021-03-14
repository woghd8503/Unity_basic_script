using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic13 : MonoBehaviour
{
    // 루프 1. foreach 루프 2. for 루프 3. while 루프

    // 1. foreach 루프
    // 괄호 안에 루프를 돌며 반복해서 확인할 요소의 데이터 형식과 변수 이름을 적는다.

    // foreach (Type elementName in myCollectionVariable)

    public List<string> familyMembers = new List<string>();
    void Start()
    {
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        foreach (string familyMember in familyMembers)
        {
            Debug.Log(familyMember);
        }
    }

    void Update()
    {
        
    }
}
