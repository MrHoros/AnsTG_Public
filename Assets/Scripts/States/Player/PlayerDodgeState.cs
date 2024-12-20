using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeState : PlayerBaseState
{
    public PlayerDodgeState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.InputReader.DodgeEvent += OnDodge;
    }

    public override void Exit()
    {
        stateMachine.InputReader.DodgeEvent -= OnDodge;
    }

    public override void Tick(float deltaTime)
    {

    }

    private void OnDodge()
    {
        stateMachine.SwitchState(new PlayerDodgeState(stateMachine));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
