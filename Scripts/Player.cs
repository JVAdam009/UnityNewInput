using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5;

    [SerializeField] private GameObject _projectile;

    [SerializeField] private Transform _bulletSpawn;
    
    [SerializeField] private float _fireDelay = 0.5f;

    private float _Canfire = -1;
    private int Ammo = 3;


    public void Fire()
    {
        if (Time.time > _Canfire && Ammo > 0)
        {
            Instantiate(_projectile, _bulletSpawn.position, Quaternion.identity);
            _Canfire = Time.time + _fireDelay;
            Ammo--;
        }
    }

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * Time.deltaTime * _moveSpeed);
    }
}
