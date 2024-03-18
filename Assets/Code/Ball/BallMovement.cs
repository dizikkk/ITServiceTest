using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ITServiceTest
{
    [Serializable]
    public class BallMovement : IBall
    {
        [SerializeField]
        private BallMovementConfig config;
        
        [SerializeField]
        private Rigidbody rigidbody;
        
        private Vector3 normal;
        private Vector3 moveDirection;
        
        public void Init()
        {
            moveDirection = RandomDirection() * config.startedSpeed;
            Move();
        }

        public void Move() => rigidbody.velocity = moveDirection;

        public void StopMove() => rigidbody.velocity = Vector3.zero;
        
        public void GetNewDirection(Collision collision)
        {
            normal = collision.contacts[0].normal;
            moveDirection = Vector3.Reflect(moveDirection, normal);
        }

        private Vector3 RandomDirection()
        {
            float randValue = Random.Range(-1f, 1f);
            return new Vector3(randValue < 0 ? -1f : 1f, 0f, randValue < 0 ? -1f : 1f);
        }
    }
}