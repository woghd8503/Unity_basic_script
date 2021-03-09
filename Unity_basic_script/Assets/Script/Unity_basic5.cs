using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_basic5 : MonoBehaviour
{
    string block1 = "Block 1 text";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(block1);
        string block2 = "Block 2 text";
        Debug.Log(block2);
        {
            Debug.Log(block1);
            Debug.Log(block2);
            string block3 = "Block 3 text";
            Debug.Log(block3);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
