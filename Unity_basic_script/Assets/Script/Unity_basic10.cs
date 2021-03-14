using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic10 : MonoBehaviour
{
    // ArrayList 
    public ArrayList inventory = new ArrayList();

    void Start()
    {
        inventory.Add(10);    
        inventory.Add(20);    
        inventory.Add("Adam");    
        inventory.Add(GameObject.Find("Player"));

        Debug.Log(inventory[1].GetType());
        Debug.Log(inventory[2].GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
