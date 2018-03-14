using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class PlayerAnimator : MonoBehaviour {

    public AnimatorController animatorController;
    private AnimatorState defaultState;
    
	void Start () {
        // State Machine
        AnimatorStateMachine rootStateMachine = animatorController.layers[0].stateMachine;
        rootStateMachine.states = null;
        this.defaultState = rootStateMachine.AddState("defaultState", new Vector3(400f, 200f, 0f));
        animatorController.SetStateEffectiveMotion(defaultState, Resources.Load<AnimationClip>("RawMocapData/Animations/Running/RunSlide_ToRight_1"));

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
