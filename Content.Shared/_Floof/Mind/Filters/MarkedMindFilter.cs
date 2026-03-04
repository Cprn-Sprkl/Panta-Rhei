using Content.Shared._Floof.Traits.Components;

namespace Content.Shared.Mind.Filters;

/// <summary>
/// A mind filter that checks the mind's owned entity for the Marked component, and checks its flags.
/// </summary>
public sealed partial class MarkedMindFilter : MindFilter
{
    [DataField(required: true)]
    public ObjectiveTypes ObjType = new();

    protected override bool ShouldRemove(Entity<MindComponent> ent, EntityUid? exclude, IEntityManager entMan, SharedMindSystem mindSys)
    {
        //Checks for Marked component, excludes otherwise
        if (!entMan.TryGetComponent<MarkedComponent>(ent.Comp.CurrentEntity, out var mcomp))
            return true;

        //Checks if the current objective type is Marked
        if (mcomp.TargetType.HasFlag(ObjType))
            return false;

        //Any mind that gets here does not have the objective type Marked and is removed
        return true;
    }
}
