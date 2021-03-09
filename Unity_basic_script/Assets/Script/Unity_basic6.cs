using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic6 : MonoBehaviour
{
    public int number1 = 2;
    public int number2 = 3;
    public int number3 = 7;
    // Start is called before the first frame update
    void Start()
    {
        AddAndPrintTwoNumbers(12, 14);
        AddAndPrint_TwoNumbers(number1, number2);
        AddAndPrint_TwoNumbers(number3, number1);
        AddAndPrint_TwoNumbers(number2, number1);
        AddTwoNumbers(number1, number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddAndPrintTwoNumbers(int number1, int number2)
    {
        int result = number1 + number2;
        Debug.Log(result);
    }
    void AddAndPrint_TwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        Debug.Log(result);
    }

    int AddTwoNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }
}
