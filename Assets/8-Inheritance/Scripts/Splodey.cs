using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Inheritance
{
    public class Splodey : Enemy
    {
        [Header("Splodey")]
        public float explosionRadius = 10f;
        public GameObject explosionPaticles;
        public float impactForce = 10f;

        public override void Attack()
        {
            base.Attack();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
