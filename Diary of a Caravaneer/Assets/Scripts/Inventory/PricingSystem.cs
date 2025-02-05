using UnityEngine;

public static class PricingSystem
{
    // Method to calculate the buy price
    public static int CalculateBuyPrice(Item item, float localDemandMultiplier)
    {
        return Mathf.CeilToInt(item.baseBuyPrice * item.demandMultiplier * localDemandMultiplier * item.eventMultiplier);
    }

    // Method to calculate the sell price
    public static int CalculateSellPrice(Item item, float localDemandMultiplier)
    {
        return Mathf.FloorToInt(item.baseSellPrice * item.demandMultiplier * localDemandMultiplier * item.eventMultiplier);
    }
}