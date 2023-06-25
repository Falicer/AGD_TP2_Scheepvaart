using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform Muzzle;

    public void fireProjectile(int power)
    {
        GameObject insProj = Instantiate(projectilePrefab, Muzzle.transform.position, Muzzle.transform.rotation);
        //insProj.GetComponent<Projectile>().Initialize(power);
    }
}
