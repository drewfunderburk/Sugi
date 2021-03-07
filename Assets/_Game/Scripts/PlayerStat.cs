using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public bool gold = false;
    public Animator animator;
    void Update(){
        animator.SetBool("gold", gold);
    }
}
