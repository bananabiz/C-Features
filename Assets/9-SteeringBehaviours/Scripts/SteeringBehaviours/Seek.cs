using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public class Seek : SteeringBehaviour
    {
        public Transform target;
        public float stoppingDistance = 1f;

        public override Vector3 GetForce()
        {
            // Let force = Vector3.zero
            Vector3 force = Vector3.zero;
            // IF target == null
            if (target == null)
            {
                return force;
            }
            // Let desiredForce = target position - transform position
            Vector3 desiredForce = target.position - transform.position;
            // IF desiredForce.magnitude > stoppingDistance
            if (desiredForce.magnitude > stoppingDistance)
            {
                // Set desiredForce = desiredForce.normalized * weight
                desiredForce = desiredForce.normalized * weight;
                // Set force = desiredForce - owner.velocity
                force = desiredForce - owner.velocity;
            }
            // Return the force
            return force;
        }
    }
}
