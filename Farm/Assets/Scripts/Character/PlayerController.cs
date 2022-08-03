using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float gravityValue = -9.81f;
    private PlayerInput inputAction;
    private Animator _animator;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        inputAction = gameObject.GetComponent<PlayerInput>();
        _animator = gameObject.GetComponent<Animator>(); ;
        controller.height = 0;
        controller.center = new Vector3(0, 0.5f, 0);
    }

    void FixedUpdate()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 input = inputAction.actions["Move"].ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
            _animator.SetBool("IsMove",true);
            _animator.Play("Walk");
        }
        else
        {
            _animator.SetBool("IsMove", false);
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}