using AC9649;
using UnityEngine;

namespace AC9649
{
    public class RoomLogic : MonoBehaviour
    {
        public GameObject[] furnitureSpawners;
        public int howManyFurnitureToSpawn = 1; 
        // non functional right now. all are spawning. TODO: fix this
                                                
        void Start()
        {
            for (int i = 0; i < furnitureSpawners.Length; i++)
            {
                GameObject toSpawn = furnitureSpawners[i];
                //TODO add optinal spawning
            }
        }
    }
}
