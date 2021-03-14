using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic11 : MonoBehaviour
{
    //  딕셔너리
    // 딕셔너리는 리스트와 비슷하지만, 인덱스값이 아닌 키라고 하는 문자열 값을 사용해서
    // 특정 요소에 접근한다는 차이가 있다. 
    
    // 
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
