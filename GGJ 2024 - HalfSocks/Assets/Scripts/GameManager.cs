using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject PipesHolder;
    public GameObject[] Pipes;

    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctedPipes = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
        
    }

    public void CheckPipes() { 
    
    foreach (var pipe in Pipes)
        {
            if(!pipe.GetComponent<PipeScript>().isPlaced)
            {
                Debug.Log("Está errado");
                return;
            }
            
        }

        Debug.Log("Ganhou");
        SceneManager.LoadScene(3);

    }
}
