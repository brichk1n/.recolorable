public interface IAbilityUser
{
    void UseSkill(int slotIndex); // Активация способности по номеру
    void AddSkill(ISkill skill);  // Добавление новой способности
}
