using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i;
        int[] array = new int[5];

        array[0] = 50;
        array[1] = 30;
        array[2] = 10;
        array[3] = 100;
        array[4] = 70;

      
        for (i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
    
        for (i= 4; i > -1; i--)
        {
            Debug.Log(array[i]);
        }
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
