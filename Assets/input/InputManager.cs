using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    public static Vector2 movement;
    private PlayerInput playerInput;
    private InputAction moveAction;
    private Animator animator;

    public GameObject player;
    // Start is called before the first frame update
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["movement"];
        animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = moveAction.ReadValue<Vector2>();
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
    }
}
