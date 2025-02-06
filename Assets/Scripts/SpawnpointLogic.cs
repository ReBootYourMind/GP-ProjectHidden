using UnityEngine;


namespace AC9649
{
    public class SpawnpointLogic : MonoBehaviour
    {
        public GameObject[] listOfSpawnable;
        public Camera cmr;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int randomIndex = Random.Range(0, listOfSpawnable.Length);
            GameObject toSpawn = listOfSpawnable[randomIndex];
            toSpawn.GetComponents<HideWhenFar>()[0].cmr = cmr;
            Instantiate(toSpawn, transform.position,transform.rotation);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
