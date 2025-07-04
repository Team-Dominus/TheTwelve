using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EState
{
    Idle,
    Run,
    Dash,
    Jump,
    Attack,
    Hit,
    Die
}

// State에 따른 델리게이트
public delegate void XII_IdleDelegate();
public delegate void XII_RunDelegate();
public delegate void XII_DashDelegate();
public delegate void XII_JumpDelegate();
public delegate void XII_AttackDelegate();
public delegate void XII_HitDelegate();
public delegate void XII_DieDelegate();

namespace XII.Components
{
    public class XII_StateComponent : MonoBehaviour
    {
        public EState CurrentState;

        public bool isDead = false;

        public XII_IdleDelegate     OnIdle;
        public XII_RunDelegate      OnRun;
        public XII_DashDelegate     OnDash;
        public XII_JumpDelegate     OnJump;
        public XII_AttackDelegate   OnAttack;
        public XII_HitDelegate      OnHit;
        public XII_DieDelegate      OnDie;

        //----------------------------------------------------------------

        public void StateChanged(EState newState)
        {
            if (CurrentState != newState)
            {
                CurrentState = newState;

                switch(CurrentState)
                {
                    case EState.Idle:
                        Debug.Log("State - Idle");
                        OnIdle?.Invoke();
                        break;
                    case EState.Run:
                        Debug.Log("State - Run");
                        OnRun?.Invoke();
                        break;
                    case EState.Dash:
                        Debug.Log("State - Dash");
                        OnDash?.Invoke();
                        break;
                    case EState.Jump:
                        Debug.Log("State - Jump");
                        OnJump?.Invoke();
                        break;
                    case EState.Attack:
                        Debug.Log("State - Attack");
                        OnAttack?.Invoke();
                        break;
                    case EState.Hit:
                        Debug.Log("State - Hit");
                        OnHit?.Invoke();
                        break;
                    case EState.Die:
                        Debug.Log("State - Die");
                        isDead = true;
                        OnDie?.Invoke();
                        break;
                }
            }
        }

    }
}
