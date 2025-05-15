using UnityEngine;

[RequireComponent(typeof(TopDownMovement))]
public class InputHandler : MonoBehaviour
{
    private TopDownMovement movement;

    private void Awake()
    {
        movement = GetComponent<TopDownMovement>();
    }

    private void Update()
    {
        Vector2 input = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
        movement.Move(input);
    }
}
