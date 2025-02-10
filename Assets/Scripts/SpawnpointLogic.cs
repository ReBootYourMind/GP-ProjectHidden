using UnityEditor.Rendering;
using UnityEngine;


namespace AC9649
{
    public class SpawnpointLogic : MonoBehaviour
    {
        //public Camera cmr;
        public GameObject[] listOfSpawnable;
        public bool willItSpawn = true;
        void Start()
        {
            if (willItSpawn)
            {
                int randomIndex = Random.Range(0, listOfSpawnable.Length);
                GameObject toSpawn = listOfSpawnable[randomIndex];
                GameObject self = gameObject;
                //toSpawn.transform.SetParent(self.transform);
                Instantiate(toSpawn, transform.position, transform.rotation, self.transform);
            }
        }
    }
}
