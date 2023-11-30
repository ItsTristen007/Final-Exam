using UnityEngine;

public static class InputManager
{

    private static Controls _ctrls;
    private static bool gs = false; 

    public static void Init(BallController ballController)
    {
        _ctrls = new Controls();
        
        _ctrls.StartMovement.move.performed += ctx =>
        {
            if (gs == false)
            {
                gs = true;
                ballController.startMovement();
                ballController.changeDirection();
            }
            if (gs == true)
            {
                ballController.changeDirection();
            }
            
        };
    }

    public static void SetGameControls() => _ctrls.StartMovement.Enable();
    
    
}
