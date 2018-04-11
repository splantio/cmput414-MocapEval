using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.Animations;
using UnityEngine.UI;

public class PlayerAnimator : MonoBehaviour {

    private AnimatorController animatorController;
    private AnimatorState defaultState;
    public Motion optionalMotion;
    private string mocapFileName = "";
    
	void Start () {
        // State Machine
        this.animatorController = (AnimatorController) gameObject.GetComponent<Animator>().runtimeAnimatorController;
        AnimatorStateMachine rootStateMachine = animatorController.layers[0].stateMachine;

        rootStateMachine.states = null;
        this.defaultState = rootStateMachine.AddState("defaultState", new Vector3(400f, 200f, 0f));
        if (optionalMotion)
        {
            animatorController.SetStateEffectiveMotion(defaultState, optionalMotion);
            this.defaultState.speed = 0;
        }
    }

	public void setAnimation(string newAnimation)
    {
        gameObject.transform.position = new Vector3(0,0,0);
        this.mocapFileName = newAnimation;
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
