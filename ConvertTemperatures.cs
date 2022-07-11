using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Problem 1 – Temperature Calculations with Int
        int intFahrenheit =0;
        int intCelsius;
        int intFahrenheitBack;
        Debug.Log("intFahrenheit: " + intFahrenheit);
        intCelsius = (intFahrenheit - 32) * 5 / 9;
        Debug.Log("intCelsius: " + intCelsius);
        intFahrenheitBack = (intCelsius * 9 / 5) + 32;
        Debug.Log("intFahrenheitBack: " + intFahrenheitBack);

        // Problem 2 – Temperature Calculations with Float
        float floatFahrenheit = 0;
        float floatCelsius;
        float floatFahrenheitBack;
        Debug.Log("floatFahrenheit: " + floatFahrenheit);
        floatCelsius = (floatFahrenheit - 32) * 5 / 9;
        Debug.Log("floatCelsius: " + floatCelsius);
        floatFahrenheitBack = (floatCelsius * 9 / 5) + 32;
        Debug.Log("floatFahrenheitBack: " + floatFahrenheitBack);

        // Problem 3 – Temperature Calculations with Double
        double doubleFahrenheit = 0;
        double doubleCelsius;
        double doubleFahrenheitBack;
        Debug.Log("doubleFahrenheit: " + doubleFahrenheit);
        doubleCelsius = (doubleFahrenheit - 32) * 5 / 9;
        Debug.Log("doubleCelsius: " + doubleCelsius);
        doubleFahrenheitBack = (doubleCelsius * 9 / 5) + 32;
        Debug.Log("doubleFahrenheitBack: " + doubleFahrenheitBack);
    }


}
