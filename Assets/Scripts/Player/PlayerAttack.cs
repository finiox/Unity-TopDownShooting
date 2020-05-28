using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private Camera attachedCamera = default;

    [SerializeField]
    private GameObject bulletPrefab = default;

    Quaternion _bulletRotation;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void FixedUpdate()
    {
        Vector3 mousePosition = attachedCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = DirectionTo(transform.position, mousePosition);

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        _bulletRotation = Quaternion.Euler(0, 0, angle);
    }

    void Fire()
    {
        Instantiate(bulletPrefab, transform.position, _bulletRotation);
    }

    Vector3 DirectionTo(Vector3 location, Vector3 target)
    {
        return (target - location).normalized;
    }
}
