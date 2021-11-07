using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flightpath
{
    public class SatelliteCollision : MonoBehaviour
    {
        public GameObject EventSystem;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("FlightpathAsteroid"))
            {
                EventSystem.GetComponent<LaunchManager>().OnAsteroidCollisionDetected();
            }
        }

        private void OnBecameInvisible()
        {
            if (EventSystem)
            {
                EventSystem.GetComponent<LaunchManager>().OnSatelliteLeaveWindow();
            }
        }
    }
}