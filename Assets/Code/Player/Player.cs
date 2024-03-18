using System;
using UnityEngine;

namespace ITServiceTest
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private PlayerMovement playerMovement;

        private Vector3 startedPosition;

        private void Start()
        {
            startedPosition = gameObject.transform.position;
        }

        private void FixedUpdate() => playerMovement.Move();

        public void ResetObject() => gameObject.transform.position = startedPosition;
    }
}