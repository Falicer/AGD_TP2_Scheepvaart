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
    public int homescreencounter = 0;
    public string gameScene = "CombatScene";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BackgroundChange();
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
            howtoplay.SetActive(false);
            verderButton.SetActive(false);
            SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
        }else{
            homescreencounter = 0;
        }
    }

    public void counterUp(){
        homescreencounter++;
        Debug.Log("up");
    }

    public void counterDown(){
        homescreencounter--;
        Debug.Log("up");
    }
}
