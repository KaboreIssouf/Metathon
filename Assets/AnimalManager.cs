using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalManager : MonoBehaviour
{

    public GameObject AnimalPanel, MathPanel;
    public AudioSource As;
    public GameObject[] audioBouton;

    public AudioClip scan;
    void Start()
    {
        As = GameObject.FindObjectOfType<AudioSource>();
    }

  

    public void ON_TARGET_LOST()
    {
        for (int i = 0; i < audioBouton.Length; i++)
        {
            audioBouton[i].SetActive(false);
        }
       
    }


    public void HOMME()
    {
        SceneManager.LoadScene("HOME");
    }
}
