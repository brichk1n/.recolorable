using UnityEngine;
public interface ISkill
{
    void Use(GameObject user);

    bool IsReady();

    float Cooldown { get; }
}