using UnityEngine;
using UnityEngine.AI;

namespace Assets
{
    public class AiController : MonoBehaviour 
    {

        public GameObject Goal;

        private NavMeshAgent _agent;
         
        // Use this for initialization
        void Start ()
        {
            _agent = GetComponent<NavMeshAgent>();
            _agent.SetDestination(Goal.transform.position);
        }
	
        // Update is called once per frame
        void Update () {
		
        }
    }
}
