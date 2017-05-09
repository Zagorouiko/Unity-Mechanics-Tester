using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyManager : MonoBehaviour
    {

        public PlayerHealthManager playerHealth;
        public GameObject enemy;
        public float spawnTime = 3f;
        public Transform[] spawnPoints;

        // Use this for initialization
        void Start () {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }
	
        // Update is called once per frame
        void Spawn() {
            Debug.Log("spawning");

            if (playerHealth.playerCurrentHealth <= 0f)
            {
                return;
            }

            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            GameObject enemySpawned = Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            enemySpawned.GetComponent<EnemyMovement>().target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
