using System;
using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    [Serializable]
    public class EnemyMovement : IMovable
    {
        [SerializeField]
        private EnemyMovementConfig config;

        [SerializeField]
        private Rigidbody rigidbody;

        private Vector3 direction;
        private Ball ball;

        public void GetBall(Ball ball) => this.ball = ball;
        
        public void Move()
        {
            direction = new Vector3(0f, 0f, ball.transform.position.z - rigidbody.transform.position.z);
            rigidbody.MovePosition(rigidbody.transform.position + direction * (Time.fixedDeltaTime * config.speed));
        }
    }
}