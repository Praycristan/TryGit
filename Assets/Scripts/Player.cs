using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementY;
    private float movementX;
    private float velocity;
    [SerializeField] private float speed = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (movementX * speed, movementY * speed);
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 movementVector = ctx.ReadValue<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}
