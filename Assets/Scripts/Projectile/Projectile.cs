using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 20f;

    void FixedUpdate()
    {
        transform.position += transform.up * projectileSpeed * Time.fixedDeltaTime;
    }
}
