using UnityEngine;
using System.Collections;

public class test001 : MonoBehaviour {
	
	protected Animator animator; 
    void Start () 
    {
        animator = GetComponent<Animator>();
    }
    
    void OnAnimatorIK(int layerIndex)
    {
		Debug.Log("1");
        animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot,0.1f);
    }
}
