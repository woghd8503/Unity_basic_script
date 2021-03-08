using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic3 : MonoBehaviour
{
    public bool willItBeRainingToday = true;
    public bool imLateForMeeting = true;
    public bool roadConditionsArePerfect = true;
    public bool imHugry = false;
    public bool areKidsHungry = true;
    int speedLimit = 60;
    // Start is called before the first frame update
    void Start()
    {
        if (willItBeRainingToday)
        {
            Debug.Log("Yes you need umbrella");
        }
        else
        {
            Debug.Log("No, you dont need umbrella");
        }

        if (!willItBeRainingToday)
        {
            Debug.Log("yes");
        }
        else
        {
            Debug.Log("No");
        }

        if (imLateForMeeting && roadConditionsArePerfect)
        {
            Debug.Log("I need to drive fast");
        }

        if (imHugry || areKidsHungry)
        {
            Debug.Log("I should cook some food");
        }

        if (speedLimit == 70)
        {
            Debug.Log("I can drive at maximum speed");
        }
        else if (speedLimit < 70 && speedLimit >= 30)
        {
            Debug.Log("Speed limit is less than 70 and more or equals to 30");
        }else if(speedLimit < 30)
        {
            Debug.Log("I better be driving slowly, 30mph or less");
        }
    }
    // Update is called once per frame
    void Update()
    {


    }
}