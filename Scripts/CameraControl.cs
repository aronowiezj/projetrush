using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float distanceX = 5;
    [SerializeField]
    float distanceY = 5;
    [SerializeField]
    float distanceZ = 5;
    private Camera m_Camera;
    private Vector3 m_Move;

    private void Start()
    {
        m_Camera = GetComponent<Camera>();
    }

    private void Update()
    {
        m_Camera.transform.position = new Vector3(target.transform.position.x + distanceX, target.transform.position.y + distanceY, target.transform.position.z + distanceZ);
    }
}
