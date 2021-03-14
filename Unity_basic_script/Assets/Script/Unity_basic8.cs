using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic8 : MonoBehaviour
{
    // 컬렉션(collection): 배열, 리스트, 딕셔너리처럼 여러 요소를 하나로 모아서 처리할 수 있는 
    // 데이테 형식을 통틀어서 컬렉션이라고 합니다.
    public string[] familyMembers = new string[] { "Greg", "Kate", "Adam", "Mia" };
    public string[] myArrayName = new string[4];

    private string[] familyMembers1 = new string[] { "John", "Amanda", "Chris", "Amber" };
    private string[] carsInTheGarage = new string[] { "VMPassat", "BMW" };
    private int[] doorNumbersOnMyStreet = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    private GameObject[] carsInTheScene = GameObject.FindGameObjectsWithTag("car");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
