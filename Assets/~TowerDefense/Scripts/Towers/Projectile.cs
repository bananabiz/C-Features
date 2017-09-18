using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Projectile : MonoBehaviour
    {
        public float damage = 35f; // damage dealt to whatever gets hit
        public float speed = 50f; // speed the projectile travels
        public Vector3 direction; // direction the projectile travels
        
        
        // Use this for initialization
        void Start()
        {
             
        }

        // Update is called once per frame
        void Update()
        {
            //Let velocity = direction.normalized x speed
            var velocity = direction.normalized * speed;
            //Set projectile's position += velocity x deltaTime
            transform.position += velocity * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider col)
        {
            //Let e = col's Enemy component  (get Enemy script)
            Enemy e = col.GetComponent<Enemy>();
            //If e != null
            if (e != null)
            {
                //Call e.DealDamage(damage)
                e.DealDamage(damage);
                //Destroy gameObject
                Destroy(col.gameObject);
                //If col's name == "Ground"
                if (col.name == "Ground")
                {
                    //Destroy the projectile
                    Destroy(this.gameObject);
                }
            }
        } 

    }
}
