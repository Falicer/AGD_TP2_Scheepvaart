using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boatCollision : MonoBehaviour
{
    // public GameObject boatsmoke;
    // public GameObject boatsmoke2;
    int hitAmount = 0;
    public int currentPlayer;
    public string gameScene;
    public SpriteRenderer SpriteRenderer;
    public SpriteRenderer boatsmokeRenderer;
    public SpriteRenderer boatsmoke2Renderer;
    public playerBehavior cs;

    // Start is called before the first frame update
    void Start()
    {
        // boatsmokeRenderer = boatsmoke.GetComponent<SpriteRenderer>();
        // boatsmoke2Renderer = boatsmoke2.GetComponent<SpriteRenderer>();
        GameObject go = GameObject.Find("BackgroundController");
        playerBehavior cs = go.GetComponent<playerBehavior>();
        currentPlayer = cs.startingPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        timesHit();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitAmount++;
        cs.startingPlayer++;
    }

    private void timesHit(){
        if(hitAmount == 0){
            SpriteRenderer.color = new Color(1f,1f,1f,1f);
            boatsmokeRenderer.color = new Color(1f,1f,1f,0f);
            boatsmoke2Renderer.color = new Color(1f,1f,1f,0f);
        }else if(hitAmount == 1){
            SpriteRenderer.color = new Color(1f,1f,1f,0f);
            boatsmokeRenderer.color = new Color(1f,1f,1f,1f);
            boatsmoke2Renderer.color = new Color(1f,1f,1f,0f);
        }else if(hitAmount == 2){
            SpriteRenderer.color = new Color(1f,1f,1f,0f);
            boatsmokeRenderer.color = new Color(1f,1f,1f,0f);
            boatsmoke2Renderer.color = new Color(1f,1f,1f,1f);
        }else if(hitAmount == 3){
            SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
        }
    }
}