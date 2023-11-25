using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private Transform _shootPosition;
    [SerializeField] private EnemyBullet _bulletPrefab;
    [SerializeField] private float _shootingRythm;

    private void OnEnable()
    {
        StartCoroutine(Shooting());
    }

    private IEnumerator Shooting()
    {
        bool isWork = true;
        var waitForSeconds = new WaitForSeconds(_shootingRythm);

        while (isWork)
        {
            var bullet = Instantiate(_bulletPrefab,_shootPosition.position,transform.rotation);
            
            yield return waitForSeconds;
        }
    }
}
