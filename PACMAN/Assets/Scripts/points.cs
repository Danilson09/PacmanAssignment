﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class points : MonoBehaviour
{
    
    

    
    void OnTriggerEnter2D(Collider2D co)
    {
        

        if (co.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);
            ScoreScript.scoreValue +=1;
            


        }
      

        
    }
    

    private void Update()
    {
    
    }
}