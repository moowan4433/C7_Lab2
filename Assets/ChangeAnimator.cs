using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorRoll()
    {
        this.GetComponent<Animator>().Play("Stand To Roll");
    }

    public void getAnimatorStand()
    {
        this.GetComponent<Animator>().Play("Standing W_Briefcase Idle");
    }
}
