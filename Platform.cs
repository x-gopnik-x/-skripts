using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public bool isACtive;

    
    void Update()
    {
        if (isACtive)
        {
            transform.position +=
            direction * speed * Time.deltaTime;
        }
    }
        void OnTriggerEnter(Collider other) {
            if (other.tag == "StopPlatform")
            {
                direction *= -1;
            }
            if (other.tag == "Player")
            {
                isACtive = true;
            }     
        }
        void OnTriggerExit (Collider other) {
            if (other.tag == "Player")
            {
                isACtive = false;
            }
        }
    
}
