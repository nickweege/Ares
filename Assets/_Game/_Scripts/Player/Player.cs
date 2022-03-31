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
    [SerializeField] private GameObject _mapGenerator;
    private Rigidbody2D _rb2D;
    private Camera _camera;
    private bool _isGamepad;
    private PlayerInputActions _playerInputActions;

    private void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _camera = FindObjectOfType<Camera>();

        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Player.Enable();
        _playerInputActions.Player.Shoot.performed += Shoot;
    }

    private void Update()
    {
        Move();
        Aim();

        if (_health <= 0) Death();
    }

    public PlayerInputActions GetPlayerInputActions()
    {
        return _playerInputActions;
    }

    private void Move()
    {
        Vector2 movementInputVector = _playerInputActions.Player.Movement.ReadValue<Vector2>();
        movementInputVector.Normalize();

        transform.position += new Vector3(movementInputVector.x, movementInputVector.y) * Time.deltaTime * _speed;

        float xx = Mathf.Clamp(transform.position.x, -_mapGenerator.GetComponent<MapGenerator>().GetMapWidth(), _mapGenerator.GetComponent<MapGenerator>().GetMapWidth());
        float yy = Mathf.Clamp(transform.position.y, -_mapGenerator.GetComponent<MapGenerator>().GetMapHight(), _mapGenerator.GetComponent<MapGenerator>().GetMapHight());

        transform.position = new Vector3(xx, yy);
    }

    private Vector2 Aim()
    {
        Vector2 mousePosition;
        Vector2 lookDirection;
        float lookAngle;

        mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        lookDirection = mousePosition - _rb2D.position;
        lookDirection.Normalize();

        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);

        return lookDirection;
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        GameObject shot = Instantiate(_shot, _shotStartPosition.position, _shotStartPosition.rotation);
        shot.GetComponent<Rigidbody2D>().velocity = Aim() * shot.GetComponent<Shot>().GetSpeed();
    }

    private int LoseLife(int damage)
    {
        return _health -= damage;
    }

    private void Death()
    {
        Destroy(gameObject);
        Instantiate(_deathAnimation, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Enemy":
                LoseLife(other.gameObject.GetComponent<Enemy>().GetDefaultDamage());
                other.gameObject.GetComponent<Enemy>().Death();
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Shot":
                LoseLife(other.GetComponent<Shot>().GetDefaultDamage());
                other.GetComponent<Shot>().DestroyShot();
                break;
        }
    }

    public void OnDeviceChange(PlayerInput playerInput)
    {
        _isGamepad = playerInput.currentControlScheme.Equals("Gamepad") ? true : false;
    }
}