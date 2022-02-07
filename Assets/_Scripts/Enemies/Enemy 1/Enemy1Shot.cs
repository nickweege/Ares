using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Shot : MonoBehaviour
{
    [SerializeField] private float enemy1ShotSpeed = 5f;
    private Rigidbody2D enemy1ShotRb2D;

    private void Start()
    {
        enemy1ShotRb2D = GetComponent<Rigidbody2D>();

        enemy1ShotRb2D.velocity = new Vector2(0f, -enemy1ShotSpeed);
    }
}
