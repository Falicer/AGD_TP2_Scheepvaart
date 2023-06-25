using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    Rigidbody2D rb;

    public float AliveTime = 3;
    public float Radius = 2;
    public GameObject ExplosionPrefab;

    // Start is called before the first frame update
    void Awake()
    {
        rb.GetComponent<Rigidbody2D>();

        Invoke("Explode", AliveTime);
        Invoke("EnableCollider", .2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = rb.velocity;
        float angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void Initialize(int power)
    {
        rb.AddForce(transform.right * (power / 2), ForceMode2D.Impulse);
    }

    void EnableCollider(){
        GetComponent<Collider2D>().enabled = true;
    }

    void Explode(){
        //TerrainDestroyer.instance.DestroyTerrain(transform.position, radius);

        //SpawnExplosionFX();

        //Camera.main.GetComponent<CameraShake>().shakeDuration = 0.2f;

        Destroy(gameObject);
    }

    // void SpawnExplosionFX()
    // {
    //     GameObject insExpl = Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
    //     insExpl.transform.localScale *= radius;
    //     Destroy(insExpl, .2f);
    // }
}
