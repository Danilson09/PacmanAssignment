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
    public AudioSource tickSource;
    
    public Transform spawnpoint;


    public void Respawn(){
        this.transform.position=spawnpoint.position;
    }
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
            tickSource.Play();
            Respawn();

        }
                
                
        



        }
        
    }



    // Start is called before the first frame update
    void Start()
    {
       tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){

        
        CheckInput();
        move();

        if(health == 0){
            SceneManager.LoadScene("LosingScreen");
        }

        
        
        if (pointsADD == 25 && health>0)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(++currentSceneIndex);

            switch(health){
                case 2:
                    health++;
                    break;
                case 1:
                    health += 2;
                    break;
            }
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




