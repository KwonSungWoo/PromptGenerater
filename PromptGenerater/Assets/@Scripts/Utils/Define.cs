using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Define
{


    public enum EScene
    {
        Unknown,
        TitleScene,
        PromptGeneratorScene,
    }

    public enum EUIEvent
    {
        Click,
        PointerDown,
        PointerUp,
        Drag,
    }

    public enum EJoystickState
    {
        PointerDown,
        PointerUp,
        Drag,
    }

    public enum ESound
    {
        Bgm,
        Effect,
        Max,
    }

    public enum EObjectType
    { 
        None,
        Creature,
        Projectile,
        Env,
    }

    public enum ECreatureType
    {
        None,
        Hero,
        Monster,
        NPC,
    }

    public enum ECreatureState
    {
        None,
        Idle,
        Move,
        Skill,
        Dead,
    }

    public enum EEnvState
    {
        Idle,
        OnDamaged,
        Dead,
    }

    public const int CAMERA_PROJECTION_SIZE = 12;

    public const int HERO_WIZARD_ID = 201000;
    public const int HERO_KNIGHT_ID = 201001;
}


public static class DefaultSetting
{
    public const int RATIO = 0;
    public const int STYLIZE = 0;
    public const int VERSTION = 0;
}