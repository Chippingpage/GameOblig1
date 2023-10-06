using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Bounce : MonoBehaviour
{
  

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        
        if (collision.gameObject.CompareTag("BouncySurface"))
        {
            // Get the normal of the collision to determine the direction to bounce.
            Vector3 bounceDirection = collision.contacts[0].normal;

            //Random for 1 to 5
            float bounceForce = Random.Range(4f, 10f);

            // Apply a force to the Rigidbody in the opposite direction of the collision normal.
            GetComponent<Rigidbody>().AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
        }
    }
}
