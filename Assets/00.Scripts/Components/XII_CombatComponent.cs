using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace XII.Components
{
    public class XII_CombatComponent : MonoBehaviour
    {
        //public enum AttackType
        //{
        //    BaseAttack,
        //    Skill
        //}
         
        private XII_CombatData CombatData;

        private XII_StaminaData StaminaData;

        private void Awake()
        {
            CombatData = GetComponent<XII_StatComponent>().CombatData;
        }

        public void SendDamage(Collider2D target)
        {
            Debug.Log("Send Damage to: " + target.gameObject.name);
            target.GetComponent<XII_IDamageable>().TakeDamage(this.gameObject, CombatData.Atk);

        }

    }
} 
