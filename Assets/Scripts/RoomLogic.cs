using AC9649;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AC9649
{
    public class RoomLogic : MonoBehaviour
    {
        [SerializeField] private GameObject[] furnitureSpawners;
        [SerializeField] private List<Material> wallPapers;
        [SerializeField] private int howManyFurnitureToSpawn = 1; 
        // non functional right now. all are spawning. TODO: fix this
                                                
        void Start()
        {
            AddWallPaper();
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

        private void AddWallPaper()
        {
            GameObject self = gameObject;
            int howmany = self.transform.childCount;
            int index = Random.Range(0, wallPapers.Count);
            for (int i = 0; i < howmany; i++)
            {
                Transform child = self.transform.GetChild(i);
                 
                if (child.tag == "wall")
                {
                    Renderer rend = child.GetComponent<Renderer>();
                    rend.material = wallPapers[index];

                }

            }

        }

        public static int RandomSort(GameObject a, GameObject b)
        {
            return Random.Range(-1, 2);
        }
    }
}
