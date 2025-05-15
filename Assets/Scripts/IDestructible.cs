public interface IDestructible
{
    int Durability { get; }   // Прочность
    void TakeDamage(int amount); // Урон к прочности
    void Destroy();            // Полное разрушение
}
