using System;
using System.Numerics;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public Transform targetEnemy;  // O inimigo que será atacado
    public float range = 5f;  // Alcance de ataque da torre
    public GameObject projectilePrefab;  // O projétil que será disparado
    public float fireRate = 1f;  // Frequência de ataque
    private float fireCountdown = 0f;

    void Update()
    {
        FindClosestEnemy();

        if (targetEnemy != null && Vector3.Distance(transform.position, targetEnemy.position) <= range)
        {
            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }
            fireCountdown -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        
    }

    void FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            targetEnemy = nearestEnemy.transform;
        }
        else
        {
            targetEnemy = null;
        }
    }
}
