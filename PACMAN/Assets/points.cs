using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class points : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "PACBOX")
            
            Destroy(gameObject);
    }



}