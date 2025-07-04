using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XII.Data;

namespace XII.Components
{
    public class XII_CombatComponent : MonoBehaviour
    {
        //public enum AttackType
        //{
        //    BaseAttack,
        //    Skill
        //}

        [SerializeField]
        private XII_CombatData CombatData;

        private XII_StaminaData Com_StaminaData;

        private void Awake()
        {
            //CombatData = GetComponent<XII_StatComponent>().CombatData;
            Com_StaminaData = this.GetComponent<XII_StaminaComponent>().StaminaData;
        }

        public void SendDamage(Collider2D target)
        {
            Debug.Log("Send Damage to: " + target.gameObject.name);
            target.GetComponent<XII_IDamageable>().TakeDamage(this.gameObject, CombatData.Atk);
        }
    }
} 
