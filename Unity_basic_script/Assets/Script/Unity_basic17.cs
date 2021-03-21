using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic17 : MonoBehaviour
{
    //  배열 안의 데이터 검색

    public List<string> familyMembers = new List<string>();

    void Start()
    {
        familyMembers.Add("Greg");
        familyMembers.Add("Kate");
        familyMembers.Add("Adam");
        familyMembers.Add("Mia");

        int adamsIndex = -1;

        for(int i = 0; i < familyMembers.Count; i++)
        {
            if(familyMembers[i] == "Adam")
            {
                adamsIndex = i;
                break;
            }
        }

        if (adamsIndex == -1)
        {
            Debug.Log("Adam value is not stored in the list");
        }
        else { Debug.Log("Adam value found at index " + adamsIndex); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
