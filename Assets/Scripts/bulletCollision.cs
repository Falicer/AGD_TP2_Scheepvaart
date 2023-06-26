using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollision : MonoBehaviour
{
    GameObject playerFinder;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    void Start(){
        StartCoroutine(WaitAndDestroy(3.0f));
        playerFinder = GameObject.Find("BackgroundController");
        //audioSource = GameObject.Find("BackgroundController").GetComponent<AudioSource>();
        //audioSource.PlayOneShot(clip, volume);
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //audioSource.Stop();
        Debug.Log("Collision");
        Destroy(gameObject);
        playerFinder.GetComponent<playerBehavior>().startingPlayer++;

    }

    //collision.gameObject.GetComponent<boatCollision>().currentPlayer++;

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private IEnumerator WaitAndDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Waited for " + waitTime + " seconds");
        Destroy(gameObject);
        playerFinder.GetComponent<playerBehavior>().startingPlayer++;
        //audioSource.Stop();
    }

    private void DestroyBullet()
    {
        this.gameObject.SetActive(false); //We just set the object inactive instead of destroying it.
    }
}