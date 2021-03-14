using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic11 : MonoBehaviour
{
    //  딕셔너리
    // 딕셔너리는 리스트와 비슷하지만, 인덱스값이 아닌 키라고 하는 문자열 값을 사용해서
    // 특정 요소에 접근한다는 차이가 있다. 
    
    // 딕셔너리로 단연 해시테이블 Hashtable을 들 수 있다.
    // 1. 해시테이블은  List<T>나 ArrayList처럼 동적으로 크기를 바꿀 수 있다.
    // 2. ArrayList와 마찬가지로 해시테이블에도 다양한 데이터 형식을 저장할 수 있다.
    // 3. 해시테이블은 퍼블릭 멤버여도 유니티의 제한 때문에 Inspector 창에 나타나지 않는다.

    // 해시 테이블에 요소를 추가하려면 문자열 키를 함께 추가해야 한다. 키가 있어야만 원하는
    // 값을 가져올 수 이따. 이미 한 번 이야기했지만 ArrayList와 해시테이블의 가장 큰 차이점으 
    // 다시 강조하자면 ArrayList는 정숫값인 인덱스를 사용해서 데이터를 저장하지만, 해시테이블은
    // 문자열 키를 사용해서 데이터를 저장한다.

    public Hashtable personalDetails = new Hashtable();
    void Start()
    {
        personalDetails.Add("firstName", "Greg");
        personalDetails.Add("lastName", "Lukosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", true);
        personalDetails.Add("age", 29);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
