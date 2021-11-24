using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pausestart : MonoBehaviour
{
  
    public void stop(InputAction.CallbackContext ctx)
    {
        Time.timeScale = 0f;
    }

}
