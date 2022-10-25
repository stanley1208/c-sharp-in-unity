using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;



    // Update is called once per frame
    void Update()
    {
        Vector3 newScale1 = transform.localScale;
        newScale1.x += scaleFactorSignMultiplier * ScaleFactorPerSecond* Time.deltaTime;
        newScale1.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale1;


        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
        
    }
}
