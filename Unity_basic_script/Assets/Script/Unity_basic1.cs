using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic1 : MonoBehaviour
{
    public int myNumber = 19;
    public int number1 = 2;
    public int number2 = 9;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(2 + 9);

        Debug.Log(11 + myNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) AddTwoNumbers();
    }

    private void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);
    }
}
