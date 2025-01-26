using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefabExplosive; // Prefab de la bala
    [SerializeField] private GameObject bulletPrefabPiercing; // Prefab de la bala
    [SerializeField] private Transform firePoint; // Punto desde donde se dispara la bala
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private GunScriptable scriptable;

    // Método para disparar la bala
    public void Shoot()
    {
        if (firePoint != null)
        {
            GameObject bullet;
            switch (scriptable.bulletType)
            {
                default:
                    break;
                case TypeOfBullet.Explosive:
                    bullet = Instantiate(bulletPrefabExplosive, firePoint.position, firePoint.rotation);
                    bullet.GetComponent<BulletLogic>().SetMovement(firePoint.position, bulletSpeed);
                    break;
                case TypeOfBullet.Piercing:
                    bullet = Instantiate(bulletPrefabPiercing, firePoint.position, firePoint.rotation);
                    bullet.GetComponent<BulletLogic>().SetMovement(firePoint.position, bulletSpeed);
                    break;
            } 


            // Aplicar velocidad a la bala si tiene Rigidbody
            //  Rigidbody rb = bullet.GetComponent<Rigidbody>(); la bala tiene .set 

            // set de la bala rb.velocity = firePoint.forward * bulletSpeed;
        }
        else
        {
            Debug.LogWarning("BulletPrefab o FirePoint no asignados.");
        }
    }
}