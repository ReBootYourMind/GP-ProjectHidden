using AC9649;
using UnityEngine;
namespace AC9649
{
    public class FurnitureLogic : MonoBehaviour
    {
        public GameObject[] possibleFurniture;
        public int howManyFindableToSpawn = 1; 
        // non functional right now. all are spawning. TODO: fix this
                                               
        void Start()
        {
            Debug.Log("furniture runs");
            int randomIndex = UnityEngine.Random.Range(0, possibleFurniture.Length);
            GameObject toSpawn = possibleFurniture[randomIndex];
            GameObject self = gameObject;
            Instantiate(toSpawn, transform.position, transform.rotation, self.transform);
        }
    }
}
