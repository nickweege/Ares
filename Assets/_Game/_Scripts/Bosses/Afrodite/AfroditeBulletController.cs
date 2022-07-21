using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfroditeBulletController : BulletBase
{
    [SerializeField] private float _stopingDist;
    [SerializeField] private float _timeToRecover;
    [SerializeField] private Transform _damageAnimSpawnPoint;
    private bool _isOnStopingDist = false;

    protected override void Awake()
    {
        base.Awake();
        _destroyVisibleBulletTimer = _timeToDestroyVisibleBullet;
    }

    private void Update()
    {
        MoveProjectile();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Satellite"))
            DestroyBullet();

        if (other.CompareTag("ArenaCollider"))
            DestroyBullet();
    }

    public override void DestroyBullet()
    {
        Instantiate(_damageAnim, _damageAnimSpawnPoint.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void MoveProjectile()
    {
        var playerPos = PlayerMainShipController.Instance.transform.position;

        if (Vector2.Distance(transform.position, playerPos) < _stopingDist)
            _isOnStopingDist = true;

        if (Vector2.Distance(transform.position, playerPos) >= _stopingDist && !_isOnStopingDist)
        {
            Vector2 bulletDir = PlayerMainShipController.Instance.transform.position - transform.position;
            bulletDir.Normalize();
            float bulletAngle = Mathf.Atan2(bulletDir.y, bulletDir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, bulletAngle);
            _direction = new Vector3(bulletDir.x, bulletDir.y);
            transform.position += _direction * Time.deltaTime * _speed;
        }

        if (_isOnStopingDist)
            transform.position += _direction * Time.deltaTime * _speed;
    }
}