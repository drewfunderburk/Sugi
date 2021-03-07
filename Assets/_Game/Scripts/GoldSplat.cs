using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSplat : MonoBehaviour
{
    
    public GameObject player;
    Collider2D check;
    // Start is called before the first frame update
    void Start()
    {
        check = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(check.IsTouching(player.GetComponent<Collider2D>())){
            player.GetComponent<PlayerStat>().gold = true;
        }
    }
}
