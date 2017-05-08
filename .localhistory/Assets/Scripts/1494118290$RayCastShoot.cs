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

        // Use this for initialization
        void Start () {
            laserLine = GetComponent<LineRenderer>();
        }
	
        // Update is called once per frame
        void Update () {
		
        }
    }
}
