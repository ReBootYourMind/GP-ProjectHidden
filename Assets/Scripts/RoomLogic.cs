using AC9649;
using System.Linq;
using UnityEngine;

namespace AC9649
{
    public class RoomLogic : MonoBehaviour
    {
        [SerializeField] private GameObject[] furnitureSpawners;
        [SerializeField] private int howManyFurnitureToSpawn = 1; 
        // non functional right now. all are spawning. TODO: fix this
                                                
        void Start()
        {
            System.Array.Sort(furnitureSpawners, RandomSort);
            // TODO: fix random; I have a feeling it doesnt work. 
            for (int i = 0; i < furnitureSpawners.Length; i++)
            {
                if (howManyFurnitureToSpawn > 0)
                {
                    furnitureSpawners[i].GetComponent<FurnitureLogic>().SpawnFurniture();
                    howManyFurnitureToSpawn--;
                }
                else break;
            }
        }


        public static int RandomSort(GameObject a, GameObject b)
        {
            return Random.Range(-1, 2);
        }
    }
}
