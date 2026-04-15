using Content.Server.StationEvents.Events;
using Content.Server._Floof.StationEvents.Events;
using Robust.Shared.Audio;

namespace Content.Server._Floof.StationEvents.Components;

[RegisterComponent, Access(typeof(GlimmerResearchStealerRule))]
public sealed partial class GlimmerResearchStealerRuleComponent : Component
{
    [DataField]
    public int MinToSteal = 1;
    [DataField]
    public int MaxToSteal = 8;
    [DataField]
    public SoundSpecifier GlimmerStealSound = new SoundPathSpecifier("/Audio/_DV/CosmicCult/ability_siphon.ogg");
    
   [DataField]
   public ProtoId<RadioChannelPrototype> AnnouncementChannel = "Science"; 
}
