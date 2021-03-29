using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    // variables
    [SerializeField]
    private float distanceAway;
    [SerializeField]
    private float distanceUp;
    [SerializeField]
    private float smooth;
    [SerializeField]
    private Transform followXForm;

    //private global only
    private Vector3 lookDir;
    private Vector3 targetPosition;

    // smoothing and damping
    private Vector3 velocityCamSmooth = Vector3.zero;
    [SerializeField]
    private float camSmoothDampTime = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        followXForm = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
         Vector3 characterOffset = followXForm.position + new Vector3(0f, distanceUp, 0f); ;

         lookDir = characterOffset - this.transform.position;
         lookDir.y = 0;
         lookDir.Normalize();


         targetPosition = characterOffset + followXForm.up * distanceUp - lookDir * distanceAway;


        CompensateForWalls(characterOffset, ref targetPosition);
        smoothPosition(this.transform.position, targetPosition);
        transform.LookAt(followXForm);

        CompensateForWalls(characterOffset, ref targetPosition);
    }

    private void CompensateForWalls (Vector3 fromObject, ref Vector3 toTarget)
    {
        Debug.DrawLine(fromObject, toTarget, Color.cyan);

        // compensate for walls between camera

        RaycastHit wallHit = new RaycastHit();

        if (Physics.Linecast(fromObject, toTarget, out wallHit))
        {
            Debug.DrawRay(wallHit.point, Vector3.left, Color.red);
            toTarget = new Vector3(wallHit.point.x, toTarget.y, wallHit.point.z);
        }
    }

    private void smoothPosition(Vector3 fromPos, Vector3 toPos)
    {
        this.transform.position = Vector3.SmoothDamp(fromPos, toPos, ref velocityCamSmooth, camSmoothDampTime);
    }

}
