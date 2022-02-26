using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public void getAnimatorDefeate(){
        this.GetComponent<Animator>().Play("aj@Big Kidney Hit");
    }

    public void  getAnimatorRumba(){
        this.GetComponent<Animator>().Play("aj@Flip Kick");
    }
}
