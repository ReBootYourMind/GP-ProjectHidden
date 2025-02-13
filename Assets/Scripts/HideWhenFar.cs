using UnityEngine;

namespace AC9649
{
    public class HideWhenFar : MonoBehaviour
    {
        private Camera cmr;
        [SerializeField] private float hideDistance = 5.0f;
        [SerializeField] private float hideSparkle = 10.0f;
        private GameObject self;
        private ParticleSystem sparkle;
        void Start()
        {
            self = gameObject;
            cmr = Camera.main;

            if (cmr == null)
            {
                Debug.LogError("sparkles need to find the camera to function");
            }
            sparkle = self.GetComponentInChildren<ParticleSystem>();
        }
        void Update()
        {
            float distance = (cmr.transform.position - self.transform.position).magnitude;

            if (distance < hideDistance)
            {
                self.GetComponent<MeshRenderer>().forceRenderingOff = false;
            }
            else
            {
                self.GetComponent<MeshRenderer>().forceRenderingOff = true;
            }

            if (distance < hideSparkle)
            {
                sparkle.GetComponent<ParticleSystemRenderer>().enabled = true;
                //sparkle.Play();
            }
            else
            {
                sparkle.GetComponent<ParticleSystemRenderer>().enabled = false;
                //sparkle.Stop();
            }
        }
    }
}
