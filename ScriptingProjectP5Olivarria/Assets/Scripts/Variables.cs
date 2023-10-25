using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
   public int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyingByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    int MultiplyingByTwo(int number)
    {
        int result;
        result = number * 2;
        return result; 

    }
}




