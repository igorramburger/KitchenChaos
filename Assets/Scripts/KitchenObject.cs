using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObject;

    private IKitchenObjectParent kitchenObjectParent;

    public KitchenObjectsSO GetKitchenObjectsSO() 
    { 
        return kitchenObject; 
    }

    public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
    {
        if(this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.ClearKitchenObject();
        }

        if(kitchenObjectParent.HasKitchenObject())
        {
            Debug.LogError("IKitchenObjectParent has already a KitchenObject!");
        }

        this.kitchenObjectParent = kitchenObjectParent; 
        kitchenObjectParent.SetKitchenObject(this);

        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public IKitchenObjectParent GetKitchenObjectParent() 
    { 
        return kitchenObjectParent; 
    }

    public void DestroySelf()
    {
        kitchenObjectParent.ClearKitchenObject();

        Destroy(gameObject);
    }

    public static KitchenObject SpawnKitchenObject(KitchenObjectsSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
    {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

        KitchenObject kitchenobject = kitchenObjectTransform.GetComponent<KitchenObject>();

        kitchenobject.SetKitchenObjectParent(kitchenObjectParent);

        return kitchenobject;
    }
}
