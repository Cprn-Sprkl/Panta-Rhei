using Content.Shared.Actions;
using Content.Shared.Actions.Components;
using Content.Shared.Ninja.Systems;
using Robust.Shared.GameStates;
using Robust.Shared.Map;
using Robust.Shared.Prototypes;

namespace Content.Shared.Ninja.Components;

/// <summary>
/// Adds an action to dash, teleport to clicked position, when this item is held.
/// Cancel <see cref="CheckDashEvent"/> to prevent using it.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(DashAbilitySystem)), AutoGenerateComponentState]
public sealed partial class DashAbilityComponent : Component
{
    /// <summary>
    /// The action id for dashing.
    /// </summary>
    [DataField]
    public EntProtoId<WorldTargetActionComponent> DashAction = "ActionEnergyKatanaDash";

    [DataField, AutoNetworkedField]
    public EntityUid? DashActionEntity;

    // Euphoria | doafter dash start
    [DataField]
    public float DashTime = 0.5f;

    [DataField]
    public EntityCoordinates Destination;

    [DataField]
    public EntityUid Dasher;

    [DataField]
    public bool Handled;
    // Euphoria | doafter dash end
}

public sealed partial class DashEvent : WorldTargetActionEvent;
