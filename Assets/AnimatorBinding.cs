using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class AnimatorBinding : MonoBehaviour
{

    [SerializeField] Animator animController;
    private string currentAnimaton;
    private string FORWARD = "Move_Forward";
    private string IDLE = "Idle_Normal_SwordAndShield 0";
    private string BACKWARD = "Move_Backward";
    private string LEFT = "Move_Left";
    private string RIGHT = "Move_Right";
    GameObject playerGameObject;
    Vector2 joystickDirection;
    [SerializeField] PlayerMove playerMove;




    // Start is called before the first frame update
    void Start()
    {
        playerGameObject = GameObject.Find("Player");


    }

    // Update is called once per frame
    void Update()
    {
        joystickDirection = playerMove.JoystickDirection;
        Debug.Log(joystickDirection.x);

        if (joystickDirection.y > 0)
        {
            ChangeAnimationState(FORWARD);
            Debug.Log("Move_Forward");
        }
        else if (joystickDirection.y == 0 && joystickDirection.x == 0)
        {
            ChangeAnimationState(IDLE);
            Debug.LogWarning("Idle_Normal_SwordAndShield 0");
        }
        else if (joystickDirection.y < 0)
        {
            ChangeAnimationState(BACKWARD);
            Debug.Log("Move_Backward");
        }
        else if (joystickDirection.x < 0)
        {
             ChangeAnimationState(LEFT);
             Debug.Log("Move_Left");
        } 
        else if (joystickDirection.x > 0)
        {
            ChangeAnimationState(RIGHT);
            Debug.Log("Move_Right");
        }
    }



    void ChangeAnimationState(string newAnimation)
    {
        if (currentAnimaton == newAnimation) return;

        animController.Play(newAnimation);
        currentAnimaton = newAnimation;
    }

}

