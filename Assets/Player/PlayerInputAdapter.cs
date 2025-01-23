using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputAdapter : MonoBehaviour
{

    private InputFrame inputs;

    private void Awake()
    {
        inputs = new();
    }

    public InputFrame GetInputFrame()
    {
        return inputs;
    }


    public void OnMove(InputValue value)
    {
        inputs.move = value.Get<Vector2>();

    }

    public void OnAttack(InputValue value)
    {
        if (value.Get<float>() == 1)
        {
            inputs.Attack = true;
        }
        else
        {
            inputs.Attack = false;
        }

    }
    public void OnJump(InputValue value)
    {
        if (value.Get<float>() == 1)
        {
            inputs.Jump = true;
        }
        else
        {
            inputs.Jump = false;
        }

    }
}
