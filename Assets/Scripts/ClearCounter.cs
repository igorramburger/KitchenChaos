using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{

    [SerializeField] private KitchenObjectsSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // No kitchenobject here
            if (player.HasKitchenObject())
            {
                // Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // Play not carrying anything
            }
        }
        else
        {
            //There is a kitcheboject here
            if(player.HasKitchenObject())
            {
                // Player is carrying something
            }
            else
            {
                // Player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
