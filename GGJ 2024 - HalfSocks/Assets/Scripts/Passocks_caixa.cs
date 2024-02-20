using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passocks_caixa : MonoBehaviour
{
    public BoxDeliverPacoca cubo1;
    public AudioSource audio3;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TalkPassocks()
    {

        audio3.Play();
        animator.SetBool("isTalk", true);

        if (audio3.time > 119)
        {
            animator.SetBool("isTalk", false);
        }
    }
}
