using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject _deathAnim;
    private Player _playerScript;

    private void Start() => _playerScript = GetComponent<Player>();

    private void Update()
    {
        if (_playerScript.Health <= 0)
            PlayerDeath();
    }

    public void PlayerDeath()
    {
        Destroy(gameObject);
        Instantiate(_deathAnim, transform.position, Quaternion.identity);
    }
}