using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class PlayerAnimator : MonoBehaviour {

    public AnimatorController animatorController;
    private AnimatorState defaultState;
    public Motion optionalMotion;
	public AnimatorStateMachine rootStateMachine;
    
	void Start () {
        // State Machine
        rootStateMachine = animatorController.layers[0].stateMachine;
        rootStateMachine.states = null;
        this.defaultState = rootStateMachine.AddState("defaultState", new Vector3(400f, 200f, 0f));
        if (optionalMotion)
        {
            animatorController.SetStateEffectiveMotion(defaultState, optionalMotion);
        } else
        {
            animatorController.SetStateEffectiveMotion(defaultState, Resources.Load<AnimationClip>("RunSlide_ToRight_1"));
        }
	}

	void setAnimation(string newAnimation){
		print (newAnimation);
	}


}
