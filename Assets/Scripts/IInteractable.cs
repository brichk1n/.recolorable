using UnityEngine;
public interface IInteractable
{
    void Interact(GameObject instigator); // Взаимодействие с объектом
    string GetInteractionHint();          // Подсказка (например, "Нажми E")
}
