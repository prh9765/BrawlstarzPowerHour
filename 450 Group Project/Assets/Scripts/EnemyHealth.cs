﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Vector3 scale;
    Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
        enemy = GetComponentInParent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        scale.x = enemy.hp / enemy.hpMax;
        transform.localScale = scale;
    }
}
