using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject prefab;
    private GameObject bullet;
    public GameObject cannon;
    public float time;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            time += Time.deltaTime;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            bullet = Instantiate(prefab, cannon.transform.position, cannon.transform.rotation);
            bullet.GetComponent<Bullet>().force = time * 20;
            time = 0;
        }
    }
}
