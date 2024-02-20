using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxDeliverDog : MonoBehaviour
{
    NPCZEmeia _nPCZEmeia;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dono"))
        {
            Destroy(gameObject);
        }
    }
}