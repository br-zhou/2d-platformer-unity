using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Enemy_Master : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health h = collision.GetComponent<Health>();

        if(h != null)
        {
            h.Kill();
        }
    }
}
