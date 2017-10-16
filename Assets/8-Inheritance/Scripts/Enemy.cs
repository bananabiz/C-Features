using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Inheritance
{
    public class Enemy : MonoBehaviour
    {
        [Header("Enemy")]
        public int health;
        public int damage;
        public float attackRate = 5f;
        public float attackRadius = 10f;

        private float attackTimer = 0f;
        protected NavMeshAgent nav;
        protected Rigidbody rigid;

        public virtual void Attack()
        {

        }

        // Update is called once per frame
        void Update()
        {
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackRate)
            {
                Attack();
                attackTimer = 0f;
            }
        }
    }
}
