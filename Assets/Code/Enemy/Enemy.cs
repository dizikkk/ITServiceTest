using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private EnemyMovement movement;

        private Vector3 startedPosition;
        private Ball ball;

        [Inject]
        private void Construct(Ball ball) => this.ball = ball;

        private void Start()
        {
            startedPosition = gameObject.transform.position;
            movement.GetBall(ball);
        }

        private void FixedUpdate() => movement.Move();
        
        public void ResetObject() => gameObject.transform.position = startedPosition;
    }
}