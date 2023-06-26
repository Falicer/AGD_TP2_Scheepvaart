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
    public GameObject dutchWin;
    public GameObject dutchWhatif;
    public GameObject dutchWait;
    public GameObject britWin;
    public GameObject britWhatif;
    public GameObject britWait;

    public AudioSource audioSource;
    public AudioClip backgroundMusic;
    public float volume = 0.5f;

    public static int homescreencounter = 0;
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
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);       
        }else if(homescreencounter == 1){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(true);
            howtoplay.SetActive(false);
            backButton.SetActive(true);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 2){
            homescreen.SetActive(false);
            disclaimer.SetActive(true);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 3){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(true);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 4){
            SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
            verderButton.SetActive(false);
        }else if(homescreencounter == 5){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(true);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 6){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(true);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 7){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(true);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 8){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(true);
            britWhatif.SetActive(false);
            britWait.SetActive(false);
        }else if(homescreencounter == 9){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            dutchWait.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(true);
            britWait.SetActive(false);
        }else if(homescreencounter == 10){
            homescreen.SetActive(false);
            disclaimer.SetActive(false);
            slagbijsolbay.SetActive(false);
            howtoplay.SetActive(false);
            backButton.SetActive(false);
            verderButton.SetActive(true);
            dutchWin.SetActive(false);
            dutchWhatif.SetActive(false);
            britWin.SetActive(false);
            britWhatif.SetActive(false);
            britWait.SetActive(true);
        }
        else{
            homescreencounter = 0;
        }
    }

    public void counterUp(){
        if(homescreencounter == 4){

        }else if(homescreencounter == 7 || homescreencounter == 10){
            SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
            verderButton.SetActive(false);
        }
        else{
        homescreencounter++;
        }
    }

    public void counterDown(){
        homescreencounter--;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
