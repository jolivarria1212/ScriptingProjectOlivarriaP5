using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimittemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's temperature is less than the coldest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("Coffe is too hot.");
        }
        // If it isn't, but the coffee temperture is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimittemperature)
        {
            //... do this.
            print("Coffee is too cold.");
        }    
        // If it is neither of those then...
        else
        {
            //...do this.
            print("Coffee is just right.");
        }
    }
}
