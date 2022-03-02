using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _shot;
    [SerializeField] private Transform _shotStartPosition;
    [SerializeField] private GameObject _deathAnimation;
    [SerializeField] private float _xLimit;
    [SerializeField] private float _yLimit;
    [SerializeField] private Camera _camera;
    private PlayerInputActions _playerInputActions;
    private Rigidbody2D _rb2D;
    private Vector2 _mousePosition;

    private void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();

        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Player.Enable();
        _playerInputActions.Player.Shoot.performed += Shoot;
    }

    private void Update()
    {
        Moving();
        Aiming();
        
        if (_health <= 0) Death();
    }

    private void Moving()
    {
        Vector2 inputVector = _playerInputActions.Player.Movement.ReadValue<Vector2>();
        inputVector.Normalize();

        transform.position += new Vector3(inputVector.x, inputVector.y, transform.position.z) * Time.deltaTime * _speed;

        float x = Mathf.Clamp(transform.position.x, -_xLimit, _xLimit);
        float y = Mathf.Clamp(transform.position.y, -_yLimit, _yLimit);

        transform.position = new Vector3(x, y, transform.position.z);
    }

    private Vector2 Aiming()
    {
        _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDirection = _mousePosition - _rb2D.position;
        lookDirection.Normalize();

        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);

        return lookDirection;
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        GameObject shot = Instantiate(_shot, _shotStartPosition.position, _shotStartPosition.rotation);
        shot.GetComponent<Rigidbody2D>().velocity = Aiming() * shot.GetComponent<Shot>().Speed;
    }

    private void SetHorizontalLimit()
    {
        if (transform.position.x < -_xLimit) transform.position = new Vector3(_xLimit, transform.position.y, transform.position.z);
        if (transform.position.x > _xLimit) transform.position = new Vector3(-_xLimit, transform.position.y, transform.position.z);
    }

    private int LoseLife(int damage)
    {
        return _health -= damage;
    }

    private void Death()
    {
        Destroy(gameObject);
        Instantiate(_deathAnimation, transform.position, transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemy":
                LoseLife(other.gameObject.GetComponent<Enemy>().DefaultDamage);
                other.gameObject.GetComponent<Enemy>().Death();
                FindObjectOfType<EnemiesGenerator>().GetCoins(other.gameObject.GetComponent<Enemy>().CoinsValue);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Shot":
                LoseLife(other.GetComponent<Shot>().DefaultDamage);
                other.GetComponent<Shot>().DestroyShot();
                break;
        }
    }
}