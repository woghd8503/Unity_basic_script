using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic14 : MonoBehaviour
{
    // foreach  루프를 반복할 때는 지역 변수를 사용해서 원하는 데이터에
    // 직접 접근 할 수 있다. for 루프도 변수가 필요한다.
    // 초기화 initialize, 조건식 condition, 증감문 iterator 
    // Start is called before the first frame update
    public List<string> mydreams = new List<string>();
    void Start()
    {
        mydreams.Add("Become_A_sportsEntrepreneur");
        mydreams.Add("Go_to_University_in_the_UK");
        mydreams.Add("Master_English");
        mydreams.Add("Loose weight");


        for(int i = 0; i < mydreams.Count; i++)
        {
            Debug.Log("myDreams are " + mydreams[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
