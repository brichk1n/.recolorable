using UnityEngine;

[RequireComponent(typeof(TopDownMovement))]
public class InputHandler : MonoBehaviour
{
    private TopDownMovement movement;
    private Attack attack;

    private void Awake()
    {
        movement = GetComponent<TopDownMovement>();
        attack = GetComponent<Attack>();
    }

    private void Update()
    {
        Vector2 input = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
        movement.Move(input);

        if (Input.GetMouseButtonDown(0)) // ЛКМ
        {
            attack.Use();
        }
    }
}
