using Content.Shared._DV.Traits.Effects;
using Content.Shared._Floof.HeightAdjust;

namespace Content.Shared._Floof.Traits.Effects;

/// <summary>
/// Effect that modifies a fixture of an entity.
/// </summary>
public sealed partial class ModifyFixtureEffect : BaseTraitEffect
{
    /// <summary>
    /// The amount to modify the fixture by.
    /// </summary>
    [DataField(required: true)]
    public float Factor = 1f;

    public override void Apply(TraitEffectContext ctx)
    {
        ctx.EntMan.System<FixtureHelperSystem>().TryAdjustFixtures(ctx.Player, Factor);
    }
}
