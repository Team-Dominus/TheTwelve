using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace XII.Components
{
    public class XII_CombatComponent : MonoBehaviour
    {
        private XII_CombatData CombatData;
        private XII_BaseAttackComponent BaseAttackComponent;
        private XII_SkillComponent SkillComponent;

        private XII_StaminaData StaminaData;
        private void Awake()
        {
            CombatData = GetComponent<XII_StatComponent>().CombatData;
            BaseAttackComponent = GetComponent<XII_BaseAttackComponent>();
            SkillComponent = GetComponent<XII_SkillComponent>();
        }
    }
}
