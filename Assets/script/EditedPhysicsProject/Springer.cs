using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(HingeJoint))]
public class Springer : MonoBehaviour
{
    [Header("Setup")]
    public Rigidbody tileBody;    
    public float stickTopOffsetY = 0.5f; 

    HingeJoint hinge;
    Rigidbody stickRb;

    void Awake()
    {
        stickRb = GetComponent<Rigidbody>();
        hinge = GetComponent<HingeJoint>();
    }

    void Start()
    {
        
        hinge.autoConfigureConnectedAnchor = false;
        hinge.connectedBody = tileBody;

        
        hinge.anchor = new Vector3(0f, stickTopOffsetY, 0f);
        hinge.connectedAnchor = Vector3.zero;

        
        stickRb.mass = Mathf.Max(0.5f, stickRb.mass);
        stickRb.angularDamping = 1.5f;   
        stickRb.linearDamping = 0.25f;

        
        UpdateAxisFromTile();
    }

    
    public void UpdateAxisFromTile()
    {
        
        Transform tileT = tileBody.transform;

        
        float y = Mathf.Abs(Mathf.DeltaAngle(tileT.eulerAngles.y, 0f));
        bool leftWall = y < 45f; 

        Vector3 worldSideways = leftWall ? tileT.right : tileT.forward;

        
        Vector3 localAxis = transform.InverseTransformDirection(worldSideways).normalized;
        hinge.axis = localAxis;

        
        hinge.useLimits = true;
        JointLimits limits = hinge.limits;
        limits.min = -60f;
        limits.max = 60f;
        hinge.limits = limits;
    }
}
