using System;
using System.Diagnostics.Contracts;
using System.Transactions;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
        public Transform target;
        public Vector3 offset;
        public float followSpeed = 0.1f;
        private void LateUpdate()
        {
                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed);
                transform.position = smoothedPosition;
        }
}