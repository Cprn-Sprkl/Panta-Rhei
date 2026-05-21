using Robust.Shared.GameStates;

namespace Content.Shared._Goobstation.Interaction.GunBlock;

/// <summary>
/// Applied to an entity to block gun usage (shoot attempts are cancelled).
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class GunBlockedComponent : Component
{
    [DataField]
    public string PopupText = "gun-block";
}
