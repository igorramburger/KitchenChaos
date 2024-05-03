using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectsSO kitchenObject;

    public KitchenObjectsSO GetKitchenObjectsSO() { return kitchenObject; }
}
