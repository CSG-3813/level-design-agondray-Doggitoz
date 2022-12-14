using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SightLine : MonoBehaviour
{
    public Transform EyePoint;
    public string TargetTag = "Player";
    public float FieldOfView = 45f;

    public bool IsTargetInSightLine { get; set; } = false;
    public Vector3 LastKnownSighting { get; set; }
    private SphereCollider ThisCollider;

    private void Awake()
    {
        LastKnownSighting = transform.position;
        ThisCollider = GetComponent<SphereCollider>();
    }

    private bool TargetInFOV(Transform target)
    {
        Vector3 directionToTarget = target.position - EyePoint.position;
        float angle = Vector3.Angle(EyePoint.forward, directionToTarget);
        return angle <= FieldOfView;
    }

    private bool HasClearLOSToTarget(Transform target)
    {
        RaycastHit hit;
        Vector3 DirToTarget = (target.position - EyePoint.position).normalized;
        if (Physics.Raycast(EyePoint.position, DirToTarget, out hit, 20))
        {
            Debug.DrawRay(transform.position, DirToTarget);
            Debug.Log(hit.transform.gameObject.name);
            if (hit.transform.CompareTag(TargetTag))
            {
                return true;
            }
        }
        return false;

    }

    private void UpdateSight(Transform target)
    {
        IsTargetInSightLine = TargetInFOV(target) && HasClearLOSToTarget(target);
        Debug.Log(HasClearLOSToTarget(target));
        if (IsTargetInSightLine)
        {
            Debug.Log("SEE");
            LastKnownSighting = target.position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            UpdateSight(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            IsTargetInSightLine = false;
        }
    }

}
