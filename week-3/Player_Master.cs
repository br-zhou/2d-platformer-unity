using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Master : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5)
        {
            Kill();
        }
    }


    public void Kill()
    {
        Scene_Master.PlayerDeath();
        Destroy(gameObject);
    }
}
