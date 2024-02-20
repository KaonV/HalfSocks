using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chefe_TALK : MonoBehaviour
{

    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!audio.isPlaying)
        {
            SceneManager.LoadScene(5);
        }
    }
}
