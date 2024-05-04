using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObject;

    private ClearCounter clearCounter;

    public KitchenObjectsSO GetKitchenObjectsSO() 
    { 
        return kitchenObject; 
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        if(this.clearCounter != null)
        {
            this.clearCounter.ClearKitchenObject();
        }

        if(clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter has already a KitchenObject!");
        }

        this.clearCounter = clearCounter; 
        clearCounter.SetKitchenObject(this);

        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter() 
    { 
        return clearCounter; 
    }


}
