using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PACBOX : MonoBehaviour
{
    int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter2D(Collider2D co)
        {
            if (co.name == "prefab4")
                health--;



               
            
        }

        nextScene();
    }


}
