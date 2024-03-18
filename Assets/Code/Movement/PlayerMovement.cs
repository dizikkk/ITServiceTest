using System;
using UnityEngine;

namespace ITServiceTest
{
    [Serializable]
    public class PlayerMovement : IMovable
    {
        [SerializeField]
        private PlayerMovementConfig config;
        
        [SerializeField]
        private Rigidbody rigidbody;
        
        private float translation;
        private Vector3 direction;

        public void Move()
        {
            translation = Input.GetAxis("Vertical");
            direction = new Vector3(0f, 0f, translation);
            rigidbody.MovePosition(rigidbody.transform.position + direction * Time.fixedDeltaTime * config.speed);
        }
    }
}