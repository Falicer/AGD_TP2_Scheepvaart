using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundChanger : MonoBehaviour
{
    public GameObject homescreen;
    public GameObject disclaimer;
    public GameObject slagbijsolbay;
    public GameObject howtoplay;
    public GameObject verderButton;
    public GameObject backButton;

    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    public float volume = 0.5f;

    public int homescreencounter = 0;
    public string gameScene = "CombatScene";

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; 
    }

    // Update is called once per frame
    void Update()
    {
        BackgroundChange();
    }

    void Awake(){   
        audioSource.PlayOneShot(backgroundMusic, volume);
    }

    public void BackgroundChange(){
        if(homescreencounter == 0){
            homescreen.SetActive(true);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
        }else if(homescreencounter == 1){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(true);
            howtoplay.SetActive(false);
            backButton.SetActive(true);
        }else if(homescreencounter == 2){
            homescreen.SetActive(false);
            disclaimer.SetActive(true);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
        }else if(homescreencounter == 3){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(true);
            backButton.SetActive(false);
        }else if(homescreencounter == 4){
            SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
            verderButton.SetActive(false);
        }else{
            homescreencounter = 0;
        }
    }

    public void counterUp(){
        homescreencounter++;
    }

    public void counterDown(){
        homescreencounter--;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
