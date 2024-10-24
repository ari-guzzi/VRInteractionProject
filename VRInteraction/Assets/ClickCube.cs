using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ClickCube : MonoBehaviour
{
    [SerializeField]
    private InputActionReference clickCube;
    public float rotationAngle = 5f;
    // Start is called before the first frame update
    void Start()
    {
        clickCube.action.performed += Turn;
    }

    // Update is called once per frame
    void Update()
    {  

    }
    void Turn(InputAction.CallbackContext _){
        // transform.Rotate(rotationAxis, rotationAngle);
        transform.Rotate(0f, rotationAngle, 0f);
}
}
