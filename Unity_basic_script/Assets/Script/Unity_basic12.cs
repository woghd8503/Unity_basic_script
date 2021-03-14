using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic12 : MonoBehaviour
{
    // 헤시값 접근
    // 헤시테이블에서 원하는 값에 접근하려면 값을 가리키는 문자열 키를 알아야 한다. 
    //  ArrayList와 비슷하게 해시테이블에도 다양한 데이터 형식을 섞어서 저장할 수 있다. 
    // 해시테이블에서 값을 가져오려면 가져올 값을 다룰 형식을 지정해야 한다. 

    // 즉 가져올 값을 명확한 데이터 형식으로 형 변화 cast해야 한다. 

    // (int)personalDetails["age"];

    // 해시테이블은 기본적으로 유니티의 Inspector 창에 나타나지 않는다. Inspector 탭을
    // 통해 퍼블릭 멤버인 해시테이블에 들어 있는 모든 키와 값을 미리 볼 수 없다는 뜻이다. 

    // 하지만 코드를 통해 값을 확인할 수 있다. 값에 접근하고 형 변환하는 방법은 이미 설명 했다.
    // 헤시테이블 안에 없는 키를 사용해서 값에 접근하려 하면 어떤 일이 벌어질까?
    // 유니티가 널 참조 에러를 내뱉으면서 프로그램이 멈춰버릴 가능성이 크다.

    public Hashtable personalDetails = new Hashtable();
    void Start()
    {
        personalDetails.Add("firstName", "Greg");
        personalDetails.Add("lastName", "Lukosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", true);
        personalDetails.Add("age", 29);

        if (personalDetails.Contains("firstName"))
        {
            Debug.Log((string)personalDetails["firstName"]);
        }
        else
        {
            Debug.Log("First name isn't stored in the hashtable");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
