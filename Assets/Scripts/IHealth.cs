public interface IHealth
{
    int CurrentHealth { get; }
    int MaxHealth { get; }

    void TakeDamage(int amount); // Получение урона
    void Heal(int amount);       // Лечение
    void Die();                  // Смерть/уничтожение
}
