using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    GameObject playerFinder;
    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip clip2;
    public AudioClip clip3;
    public float volume=0.5f;

    void Start(){
        StartCoroutine(WaitAndDestroy(3.0f));
        playerFinder = GameObject.Find("BackgroundController");
        audioSource = GameObject.Find("soundsSource").GetComponent<AudioSource>();
        audioSource.Play();
        //audioSource.PlayOneShot(clip, volume);
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "battleship"){
            //audioSource.PlayOneShot(clip2, volume);\
            Destroy(gameObject);
            playerFinder.GetComponent<playerBehavior>().startingPlayer++;

        }else if(collision.gameObject.tag == "water"){
            //audioSource.PlayOneShot(clip3, volume);
            Destroy(gameObject);
            playerFinder.GetComponent<playerBehavior>().startingPlayer++;
        }else if(collision.gameObject.tag == "air"){
            Destroy(gameObject);
            playerFinder.GetComponent<playerBehavior>().startingPlayer++;
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private IEnumerator WaitAndDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
        playerFinder.GetComponent<playerBehavior>().startingPlayer++;
        audioSource.Stop();
    }

    private void DestroyBullet()
    {
        this.gameObject.SetActive(false); //We just set the object inactive instead of destroying it.
    }
}