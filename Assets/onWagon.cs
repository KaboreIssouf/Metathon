using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onWagon : MonoBehaviour
{

    public GameObject particule_Enable, particule_Disable;


 


    private void OnEnable()
    {
        if (particule_Enable != null )
        {
            Instantiate(particule_Enable, transform);
        }
      
    }
    private void OnDisable()
    {
        if (particule_Disable != null)
        {
            Instantiate(particule_Disable, transform.position, transform.rotation) ;
            print("dddd");
        }
    }



    private void OnDestroy()
    {
        print("xxx");
    }
}
