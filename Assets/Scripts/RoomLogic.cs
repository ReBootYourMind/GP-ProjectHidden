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
        [SerializeField] private int howManyItemsToSpawn = 3;
        private List<int> usedSpawnerIndexes = new List<int>();
        // non functional right now. some are spawning. TODO: fix this

        void Start()
        {
            AddWallPaper();
            for (int i = 0; i < howManyFurnitureToSpawn; i++)
            {
                SpawnObjectSpawnerRandomlyFromTheArray();
            }
        }
        private void SpawnObjectSpawnerRandomlyFromTheArray()
        {
            // this should prevent going into the randomiser if we do not have any spawners to spawn anymore :D
            if (usedSpawnerIndexes.Count >= howManyFurnitureToSpawn)
                return;
            int randomIndex;
            do
            {
                randomIndex = Random.Range(0, furnitureSpawners.Length);
            }
            while (usedSpawnerIndexes.Contains(randomIndex));

            usedSpawnerIndexes.Add(randomIndex);
            FurnitureLogic myFL = furnitureSpawners[randomIndex].GetComponent<FurnitureLogic>();
            myFL.SpawnFurniture();
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
    }
}
