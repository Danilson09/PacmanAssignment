using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class points : MonoBehaviour
{
    
    public int pointsADD = 37;

    
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.tag == "Player")
        {

            Destroy(this.gameObject);
            pointsADD--;
            


        }
      

        
    }

    private void Update()
    {
        if (pointsADD == 24)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(++currentSceneIndex);
        }

        if (pointsADD == 0)
        {
            //call winning scene
        }
    }



}