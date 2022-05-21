using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public ParticleSystem explosionPs;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);

    }
    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    void DestroyProjectile()
    {
        Instantiate(explosionPs, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}




