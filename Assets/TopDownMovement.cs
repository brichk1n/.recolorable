using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Скорость движения

    private Rigidbody2D rb;
    private Vector2 movementInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Этот метод вызывается из InputHandler
    public void Move(Vector2 inputDirection)
    {
        movementInput = inputDirection;
    }

    private void FixedUpdate()
    {
        // Нормализуем, чтобы по диагонали скорость не увеличивалась
        Vector2 move = movementInput;
        if (move.magnitude > 1f)
            move.Normalize();

        rb.linearVelocity = move * moveSpeed;
    }
}
