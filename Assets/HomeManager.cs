using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeManager : MonoBehaviour
{
    
   public void Charger_AR()
    {
        SceneManager.LoadScene("AR Scene");
    }

    public void Charger_AR_AGNI()
    {
        SceneManager.LoadScene("AR Agni");
    }
}
