//help from youtube tutorial
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjectCollisionScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with the box has happened");
        CoundownTimer.currentTime += 100;
    

       Destroy(gameObject);
    }
}
