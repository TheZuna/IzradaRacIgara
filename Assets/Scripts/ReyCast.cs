using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReyCast : MonoBehaviour { 
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        CheckForShooting();
    }
    private void CheckForShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;


            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
            {
                Debug.Log("Hit: " + hit.collider.name);
                Debug.Log("Tag: " + hit.collider.tag);
                
                    

                if (hit.collider.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);

                }

            }
        }
    }
}
