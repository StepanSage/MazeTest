 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other != null)
        {
            if (other.CompareTag("Player"))
            {
                GlobalEventSystem.SignatureGameOver();
            }
        }
    }
}
