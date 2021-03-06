using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfroditeIdleState : AfroditeBaseState
{
    private float _timeToSwitchState = 1f;
    private float _timer;

    public override void EnterState(AfroditeController context)
    {
        _timer = _timeToSwitchState;
    }

    public override void UpdateState(AfroditeController context)
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0f)
        {
            context.SwitchState(context.FirstStageState);
        }
    }
}