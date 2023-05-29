using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Calls functionality when a trigger occurs
/// </summary>
public class OnTrigger : MonoBehaviour
{
    public GameObject floor;

    [Serializable] public class TriggerEvent : UnityEvent<Collider> { }

    // When the object enters a collision
    public TriggerEvent OnEnter = new TriggerEvent();

    // When the object exits a collision
    public TriggerEvent OnExit = new TriggerEvent();

    private void OnTriggerEnter(Collider other)
    {
        if (CanTrigger(other.gameObject))
            OnEnter?.Invoke(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (CanTrigger(other.gameObject))
            OnExit?.Invoke(other);
    }

    private bool CanTrigger(GameObject otherGameObject)
    {
        Debug.Log(otherGameObject);
        if(otherGameObject == floor)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /*private void OnValidate()
    {
        if (TryGetComponent(out Collider collider))
            collider.isTrigger = true;
    }*/
}
