using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyHealthManager : MonoBehaviour
    {
        public int enemyMaxHealth = 100;
        public int enemyCurrentHealth;

        // Use this for initialization
        void Start()
        {
            SetMaxHealth();
        }

        // Update is called once per frame
        void Update()
        {
            HurtEnemy(1);
            Debug.Log(enemyCurrentHealth);

            if (enemyCurrentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        public void HurtEnemy(int damageToGive)
        {
            enemyCurrentHealth -= damageToGive;
        }

        public void SetMaxHealth()
        {
            enemyCurrentHealth = enemyMaxHealth;
        }
    }
}
