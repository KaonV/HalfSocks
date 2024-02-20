using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialogue : MonoBehaviour
{
    public AudioSource audio;

    public GameObject indicador;
    // Start is called before the first frame update
    void Start()
    {
        indicador.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            indicador.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                
            }
        }
    }
    void OnTriggerExit(Collider other) 
    {
        indicador.SetActive(false);
    }

}
