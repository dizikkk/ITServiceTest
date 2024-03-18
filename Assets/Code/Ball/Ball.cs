using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class Ball : MonoBehaviour
    {
        [SerializeField]
        private BallMovement ballMovement;

        private Vector3 startedPosition;

        private void Start()
        {
            startedPosition = gameObject.transform.position;
            ballMovement.Init();
        }

        private void OnCollisionEnter(Collision collision)
        {
            ballMovement.GetNewDirection(collision);
            ballMovement.Move();
        }

        public async void ResetObject()
        {
            ballMovement.StopMove();
            gameObject.transform.position = startedPosition;
            await Task.Delay(1000);
            ballMovement.Init();
        }
    }
}