using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PACBOX : MonoBehaviour
{
    public int health = 3;
    public float speed = 4.0f;
    public int pointsADD = 37;
    public int pointsADD2 = 1;

    private Vector2 direction = Vector2.zero;


    void OnTriggerEnter2D(Collider2D co)
    {
        

        if (co.gameObject.tag == "points")
        {
            pointsADD--;
        }

          if (co.gameObject.tag == "points2")
        {
            pointsADD2 = pointsADD2 + 1;
        }
      

        {
        if (co.gameObject.tag == "Enemy"){
            health = health -1;
        }
                
                


            //if (health == 0)
                //make the defeat scene


        }
        
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

        
        CheckInput();
        move();

         
        
        if (pointsADD == 25)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(++currentSceneIndex);
        }

        if (pointsADD2 == 19 && health>0)
        {
            //call winning scene
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(++currentSceneIndex);
        }

        //make loosing screen
        


    
    }





    

    void CheckInput() {
        if (Input.GetKeyDown (KeyCode.LeftArrow)){
            direction = Vector2.left;
        }else if (Input.GetKeyDown (KeyCode.RightArrow)){
            direction = Vector2.right;
        }else if (Input.GetKeyDown (KeyCode.UpArrow)){
            direction = Vector2.up;
        }else if (Input.GetKeyDown (KeyCode.DownArrow)){
            direction = Vector2.down;
        }
    }

        void move (){
            transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
        }
        
        
 
}   




