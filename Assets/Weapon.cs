using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject projectilePf;
    public Transform shotPoint;
    public float timeBetweenShots;
    private float shotTime;

    private void Start()
    {
        
    }
    private void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rotation (convert the angle into a rotation)
        //rotate on the forwards axis
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.rotation = rotation;

        if(Input.GetMouseButton(0)) {
            // check if the current time 
            if(Time.time >= shotTime) {
                Instantiate(projectilePf, shotPoint.position, transform.rotation);
                shotTime = Time.time + timeBetweenShots;
            }
        }

    }
}