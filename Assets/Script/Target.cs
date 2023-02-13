using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            GameManager.Instance.IncrementScore();
            GetComponent<Renderer>().material.color = Color.green;
            gameObject.SetActive(false);
            Invoke(nameof(Reactivate), 5);
        }
    } 

    private void Reactivate()
    {
        gameObject.SetActive(true);
    }
}
