using DV.CabControls;
using HarmonyLib;
using Multiplayer.Components.Networking.World;
using Multiplayer.Utils;

namespace Multiplayer.Patches.World;

[HarmonyPatch(typeof(ItemBase))]
public static class ItemBase_Patch
{
    [HarmonyPatch(nameof(ItemBase.Awake))]
    [HarmonyPostfix]
    private static void Awake(ItemBase __instance)
    {
            Multiplayer.Log($"ItemBase.Awake() ItemSpec: {__instance?.InventorySpecs?.itemPrefabName}");
            __instance.GetOrAddComponent<NetworkedItem>();
            return;
     }
}
