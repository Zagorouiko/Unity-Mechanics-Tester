using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class RayCastShoot : MonoBehaviour
    {

        public float fireRate = .25f;
        public float weaponRange = 50f;
        public SteamVR_TrackedObject trackedController;
        public Transform gunTip;

        private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);
        private LineRenderer laserLine;
        private float nextFire;

        public int damageToGive;

        // Use this for initialization
        void Start () {
            laserLine = GetComponent<LineRenderer>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            var device = SteamVR_Controller.Input((int) trackedController.index);
            if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;

                //StartCoroutine(ShotEffect());

                Vector3 rayOrigin = gunTip.position;

                RaycastHit hit;


                if (Physics.Raycast(rayOrigin, -gunTip.forward, out hit, weaponRange))
                {
                    
                    if (hit.collider.gameObject.tag == "Enemy")
                    {
                        hit.transform.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
                        Debug.Log("Enemy Shot");
                        Debug.Log("Enemy Health: " + hit.transform.gameObject.GetComponent<EnemyHealthManager>().enemyCurrentHealth);
                    }
                    else
                    {
                        laserLine.SetPosition(1, rayOrigin + -gunTip.forward * weaponRange);
                    }
                }
            }
        }

        private IEnumerator ShotEffect()
        {
            laserLine.enabled = true;
            yield return shotDuration;
            laserLine.enabled = false;
        }

        public void ShootEnemy(Collider other)
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
        }
    }
}
