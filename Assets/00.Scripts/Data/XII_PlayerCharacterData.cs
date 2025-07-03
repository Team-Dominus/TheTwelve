using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class XII_MovementData
{
    public float MoveSpeed;

    public float JumpPower;

    public float DashPower;
    public float DashDistance;
}

[Serializable]
public class XII_HealthData
{
    public float MaxHp;
    public float Hp;
    public float Def;
}

[Serializable]
public class XII_StaminaData
{
    public float MaxStamina;
    public float Stamina;
}

[Serializable]
public class XII_CombatData
{
    public float Atk;
    public float AtkSpeed;
}

[CreateAssetMenu(fileName = "PlayerCharacterData", menuName = "Object/Character/PlayerCharacterData", order = int.MaxValue)]
public class XII_PlayerCharacterData : ScriptableObject
{
    public XII_MovementData MovementData;
    public XII_HealthData HealthData;
    public XII_StaminaData StaminaData;
    public XII_CombatData CombatData;
}
