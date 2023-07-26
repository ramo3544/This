using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction move;
    private InputAction aim;
    public Vector2 thrustVector;
    public Vector2 aimPosition;

    private void Awake()
    {
        playerInput= GetComponent<PlayerInput>();
        move = playerInput.actions["Move"];
        aim = playerInput.actions["Aim"];
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        thrustVector = GetInput(move);
    }

    public Vector2 GetInput(InputAction action)
    {
        Vector2 input = action.ReadValue<Vector2>();
        float inputX = Mathf.Clamp(input.x, -1, 1);
        float inputY = Mathf.Clamp(input.y, -1, 1);
        Vector2 normInput = new Vector2(inputX, inputY);
        return normInput;
    }
}
