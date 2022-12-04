using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TxtOnEnable : MonoBehaviour
{
    public AudioSource As;

    public AudioClip scan;

    void Start()
    {
        As = GameObject.FindObjectOfType<AudioSource>();
    }

    private void OnEnable()
    {
        As.PlayOneShot(scan);
    }
}
