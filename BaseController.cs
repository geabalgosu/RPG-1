using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseController : MonoBehaviour
{
    [SerializeField] Define.State _state = Define.State.Idle;
    
    private void Start()
    {
        Init();
    }

    public virtual Define.State State
    {
        get { return _state; }
        set {_state = value;}
    }

    private void Update()
    {
        
        switch(State)
        {
            case Define.State.Attack:
                UpdateAttack();
                break;
            case Define.State.Die:
                UpdateDie();
                break;
            case Define.State.Moving:
                UpdateMoving();
                break;
            case Define.State.Idle:
                UpdateIdle();
                break;
        }

        if (Input.anyKey == false)
        {
            UpdatePlayerIdle();
        }
    }
    public abstract void Init();
    protected virtual void UpdateIdle() { 
    
    }
    protected virtual void UpdateDie() 
    { 
    
    }
    
    protected virtual void UpdateAttack() 
    { 
            
    }

    protected virtual void UpdateMoving() 
    { 
    
    }
    protected virtual void UpdatePlayerIdle()
    {

    }
}
