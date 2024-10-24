using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class DragCube : MonoBehaviour
{
    [SerializeField]
    private GameObject controller; 
    public float rotationAngle = 10f;
    [SerializeField]
    private InputActionReference dragTriggerPress;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool isTriggerHeld = (dragTriggerPress.action.ReadValue<float>() > 0.5);
         if (isTriggerHeld) {
            Vector3 controllerPosition = controller.transform.position;
            rotationAngle = Vector3.Angle(transform.position, controllerPosition) * Mathf.Sign(Vector3.Cross(transform.position, controllerPosition).y);
            transform.Rotate(0f, rotationAngle, 0f);
        }

    }
}
