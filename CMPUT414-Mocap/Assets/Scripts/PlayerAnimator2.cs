using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.Animations;

public class PlayerAnimator2 : MonoBehaviour {

    public AnimatorController animatorController;
    private AnimatorState defaultState;
    public Motion optionalMotion;
	public AnimatorStateMachine rootStateMachine;
    Vector3 orgPos;
    
	void Start () {
        // State Machine

        rootStateMachine = animatorController.layers[0].stateMachine;
        rootStateMachine.states = null;
        this.defaultState = rootStateMachine.AddState("defaultState", new Vector3(400f, 200f, 0f));
        orgPos = gameObject.transform.position;
        //if (optionalMotion)
        //{
            //animatorController.SetStateEffectiveMotion(defaultState, optionalMotion);
        //} else
        //{
            //animatorController.SetStateEffectiveMotion(defaultState, Resources.Load<AnimationClip>("RunSlide_ToRight_1"));
        //}
	}

	public void setAnimation(string newAnimation){
		print (newAnimation);
        gameObject.transform.position = orgPos;
        animatorController.SetStateEffectiveMotion(defaultState, Resources.Load<AnimationClip>(newAnimation));
	}

    public void pauseAnimation()
    {
        this.defaultState.speed = 0;
    }

    public void playAnimation()
    {
        this.defaultState.speed = 1;
    }
}
