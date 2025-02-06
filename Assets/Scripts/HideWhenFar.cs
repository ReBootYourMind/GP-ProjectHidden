using UnityEngine;

namespace AC9649
{
    public class HideWhenFar : MonoBehaviour
    {
        public Camera cmr;
        public float hideDistance = 5.0f;
        public float hideSparkle = 10.0f;
        private GameObject self;
        private ParticleSystem sparkle;
        void Start()
        {
            self = gameObject;
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
