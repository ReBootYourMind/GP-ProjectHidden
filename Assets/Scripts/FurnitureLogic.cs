using AC9649;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace AC9649
{
    public class FurnitureLogic : MonoBehaviour
    {
        [SerializeField] private GameObject[] possibleFurniture;
        [SerializeField] private int howManyFindableToSpawn = 1;
        // non functional right now. all are spawning. TODO: fix this
        private bool hasSpawned = false;
                                               
        void Start()
        {
            //SpawnFurniture();
        }

        public void SetHowManyFindableToSpawn(int howMany)
        {
            if (howMany >= 0)
            {
                howManyFindableToSpawn = howMany;
            }
        }

        public void SpawnFurniture()
        {
            if (!hasSpawned)
            {
                //Debug.Log("furniture runs");
                int randomIndex = UnityEngine.Random.Range(0, possibleFurniture.Length);
                GameObject toSpawn = possibleFurniture[randomIndex];
                GameObject self = gameObject;
                Instantiate(toSpawn, transform.position, transform.rotation, self.transform);
                hasSpawned = true;
                SpawnpointLogic[] mySLs = toSpawn.transform.GetComponentsInChildren<SpawnpointLogic>();
                foreach (var item in mySLs)
                {
                    if (howManyFindableToSpawn > 0)
                    {
                        item.SpawnItem();
                        howManyFindableToSpawn--;
                    }
                    else break;

                }
            }
        }
    }
}
