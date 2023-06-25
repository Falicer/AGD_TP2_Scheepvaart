using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerAiming : MonoBehaviour
{
    int curAngle;

    public int MinPower = 0;
    public int MaxPower = 100;
    public AudioClip soundfx;
    private AudioSource soundSource;

    int curPower;

    public SpriteRenderer AimSprite;

    public playerShoot shootScript;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayAudio(AudioClip sound)
    {
        if(sound != null)
        {
            soundSource.clip = sound;
            soundSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            CalculateAngle();
            CalculatePower();
        }else if(Input.GetMouseButtonUp(0))
        {
            //Fire projectile
            shootScript.fireProjectile(curPower);
            PlayAudio(soundfx);
        }
    }

    void CalculateAngle()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector3 dir = mousePos-transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        UpdateAngle((int)angle);
    }

    void UpdateAngle(int angle){
        curAngle = angle;
        AimSprite.transform.rotation = Quaternion.AngleAxis(curAngle, Vector3.forward);

        if(curAngle < 0)
        {
            curAngle = 0;
        }
        if(curAngle > 200){
            curAngle = 200;
        }
    }

    void CalculatePower()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        float distance = Vector3.Distance(mousePos, transform.position);
        UpdatePower((int)distance * 2);
    }

    void UpdatePower(int amount)
    {
        curPower = Mathf.Clamp(amount, MinPower, MaxPower);

        AimSprite.transform.localScale = new Vector2(curPower / 12, curPower / 12);

    }
}
