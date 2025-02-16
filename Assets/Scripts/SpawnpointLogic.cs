using UnityEditor.Rendering;
using UnityEngine;


namespace AC9649
{
    public class SpawnpointLogic : MonoBehaviour
    {
        //public Camera cmr;
        [SerializeField] private GameObject[] listOfSpawnable;
        [SerializeField] private bool willItSpawn = true;
        private bool hasItSpawned = false;
        void Start()
        {
            if (willItSpawn)
            {
                SpawnItem();
            }
        }

        public void SpawnItem()
        {
            if (!hasItSpawned)
            {
                int randomIndex = Random.Range(0, listOfSpawnable.Length);
                GameObject toSpawn = listOfSpawnable[randomIndex];
                GameObject self = gameObject;
                Instantiate(toSpawn, transform.position, transform.rotation, self.transform);
                hasItSpawned = true;
            }

        }
    }
}
