using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed;
    float bulletVelocity;
    Lib lib;

    void Awake()
    {
        lib = gameObject.AddComponent<Lib>();
    }
    public void Use()
    {
        Vector2 direction = lib.GetDirectionToCursor();
        GameObject shotedBullet = Instantiate(bullet, lib.GetPlayerPosition(), Quaternion.identity);
        bulletVelocity = bulletSpeed * Time.fixedDeltaTime;
        // print(bulletVelocity);
        shotedBullet.GetComponent<Rigidbody2D>().linearVelocity = bulletVelocity * direction;
        Destroy(shotedBullet, 100f);
        // print("вектор :" + direction.ToString());
        // print("velocity: " + bulletVelocity);
    }
}
