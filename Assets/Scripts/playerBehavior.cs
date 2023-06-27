using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerBehavior : MonoBehaviour
{
    public int startingPlayer = 1;
    public GameObject dutchShip;
    public GameObject dutchCannon;
    public GameObject britShip;
    public GameObject britCannon;
    PolygonCollider2D dutchShipCollider;
    PolygonCollider2D britShipCollider;
    public string mainMenu;
    //int starterDetection;

    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    public float volume = 0.5f;

    private float nextActionTime = 0.0f;
    public float period = 1f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; 
        dutchShipCollider = dutchShip.GetComponent<PolygonCollider2D>();
        britShipCollider = britShip.GetComponent<PolygonCollider2D>();
    }

    void Awake(){   
        audioSource.PlayOneShot(backgroundMusic, volume);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey){
            nextActionTime = 0;
        }

        if (Time.time > nextActionTime ) {
            nextActionTime += period;
            // execute block of code here

            if(nextActionTime == 150){
            }

            if(nextActionTime >= 300){
                SceneManager.LoadScene(mainMenu, LoadSceneMode.Single);
            }  
        }

        playerDetection();


    }

    void playerDetection(){
        if(startingPlayer == 1){
            dutchCannon.SetActive(true);
            britCannon.SetActive(false);
            britShipCollider.enabled = true;
            dutchShipCollider.enabled = false;
            
        }else if(startingPlayer == 2){
            dutchCannon.SetActive(false);
            britCannon.SetActive(true);
            britShipCollider.enabled = false;
            dutchShipCollider.enabled = true;
        }else{
            startingPlayer = 1;
        }
    }
}
