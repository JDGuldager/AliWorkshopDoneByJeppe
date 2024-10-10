using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handAnimationController : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty grabAnimation;

    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("PinchFloat", pinchValue);

        float grabValue = grabAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("GrabFloat", grabValue);
    }
}
