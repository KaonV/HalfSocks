using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCZEmeia : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;

    public GameObject indicador;
    public BoxDeliverPacoca cubo1;
    public BoxDeliverDog cubo2;
    public bool complete;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        indicador.SetActive(false);
        cubo1.gameObject.SetActive(false);
        cubo2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(cubo1 == null && cubo2 == null)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }

        if(audio1.time > 42)
        {
            animator.SetBool("isTalk", false);
        }
    }
    IEnumerator WaitToStop(float seconds)
    {
        yield return new WaitForSeconds(seconds);
       
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            indicador.SetActive(true);

            if (complete == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    cubo1.gameObject.SetActive(true);
                    cubo2.gameObject.SetActive(true);
                    audio1.Play();

                    animator.SetBool("isTalk", true);

                    
                    StartCoroutine(WaitToStop(44f));
                    
                    
                    
                }
               
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    audio2.Play();
                }
            }

        }
    }
    void OnTriggerExit(Collider other)
    {
        indicador.SetActive(false);
    }

    
}
