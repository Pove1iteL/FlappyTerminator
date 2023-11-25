using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _offsetZ;

    private GameObject _bullet;
    private float _timeShoot;
    private float _startShoot;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 directon = (transform.position - _player.transform.position).normalized;
            float rotateZ = Mathf.Atan2(directon.y, directon.x) * Mathf.Rad2Deg;

            GameObject bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);

            bullet.transform.rotation = Quaternion.Euler(0f,0f,rotateZ + _offsetZ);
        }
    }
}
