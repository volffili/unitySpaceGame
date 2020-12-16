using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private const float CONSTANT_SPEED = 3F;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.forward) * (Time.deltaTime * CONSTANT_SPEED));
    }
}
