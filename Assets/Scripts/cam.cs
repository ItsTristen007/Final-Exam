using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : BallController
{
    private bool grounded;
    
    // Update is called once per frame
    void Update()
    {
        getGrounded(grounded);
        
        
        
    }
}
