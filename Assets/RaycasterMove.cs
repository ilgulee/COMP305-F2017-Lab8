using UnityEngine;

namespace Assets
{
    public class RaycasterMove : MonoBehaviour
    {

        public Camera Camera;
        private Ray _ray;
        private RaycastHit _hit;
        private GameObject _hitGameObject = null;

        void Update()
        {
            //Get object
            if (Input.GetMouseButtonDown(0))
            {
                _ray = Camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(_ray, out _hit))
                {
                    if (_hit.collider.tag== "MoveableObject")
                    {
                        _hitGameObject = _hit.collider.gameObject;
                    }
                }
            }

            if (_hitGameObject)
            {
                //Hold object
                if (Input.GetMouseButton(0))
                {
                    _ray = Camera.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(_ray, out _hit))
                    {
                        _hitGameObject.transform.position=new Vector3(_hit.point.x,_hitGameObject.transform.position.y,_hit.point.z);
                    }
                }
                //Drop object
                if (Input.GetMouseButtonUp(0))
                {
                    _hitGameObject = null;
                }
            }



        }

    }
}
