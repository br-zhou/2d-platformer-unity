using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Master : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] Transform respawnTrans;
    static Scene_Master me;
    const float respawnDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        me = this;
    }

    public static void PlayerDeath()
    {
        me.Invoke("RespawnPlayer", respawnDelay);
    }

    void RespawnPlayer()
    {
        Instantiate(playerPrefab, respawnTrans.position, Quaternion.identity);
    }

}
