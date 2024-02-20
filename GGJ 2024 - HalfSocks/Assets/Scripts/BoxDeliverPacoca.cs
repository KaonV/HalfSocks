using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxDeliverPacoca : MonoBehaviour
{
    public GameObject Passocks;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pacoca"))
        {
            Passocks.GetComponent<Passocks_caixa>().TalkPassocks();
            Destroy(gameObject);
        }
    }
}