using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falas : MonoBehaviour
{
    public AudioClip [] audios;
    public AudioSource tocador;
    // Start is called before the first frame update
    void Start()
    {
        tocador = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tocar(int num) {
       
        tocador.clip = audios[num];
        tocador.Play();
    }
    public void parar() {
        if(tocador.isPlaying)tocador.Stop();
    }
}
