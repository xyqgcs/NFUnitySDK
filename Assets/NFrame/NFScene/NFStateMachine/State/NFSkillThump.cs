﻿using UnityEngine;
using System.Collections;
using NFrame;
using NFSDK;

public class NFSkillThump : NFIState
{
    private NFBodyIdent xBodyIdent;
    private NFHeroInput xInput;
    private NFHeroMotor xHeroMotor;
    private NFHeroSync xHeroSync;

    public NFSkillThump(GameObject gameObject, NFAnimaStateType eState, NFAnimaStateMachine xStateMachine, float fHeartBeatTime, float fExitTime, bool input = false)
        : base(gameObject, eState, xStateMachine, fHeartBeatTime, fExitTime, input)
    {
        xBodyIdent = gameObject.GetComponent<NFBodyIdent>();
        xInput = gameObject.GetComponent<NFHeroInput>();
        xHeroMotor = gameObject.GetComponent<NFHeroMotor>();
        xHeroSync = gameObject.GetComponent<NFHeroSync>();
    }
    // Use this for initialization
    public override void Enter(GameObject gameObject, int index)
    {
        base.Enter(gameObject, index);

        //mAnimatStateController.PlayAnimaState(NFAnimaStateType.SkillThump);
    }

    public override void Execute(GameObject gameObject)
    {
        xHeroMotor.ProcessInput(false, false, false);
    }
}
