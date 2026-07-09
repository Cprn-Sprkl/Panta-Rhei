using Content.Shared.Eui;
using Content.Server.EUI;
using Content.Server.Ghost;
using Content.Shared._Floof.Ghost.UI;
using Content.Shared.Ghost;


namespace Content.Server._Floof.Ghost.UI;

public sealed class AcceptPublicERPEui(EntityUid uid, GhostComponent component, GhostSystem ghostSystem) : BaseEui
{
    public override void HandleMessage(EuiMessageBase message)
    {
        base.HandleMessage(message);

        if (message is not AcceptPublicERPChoiceMessage choice ||
            choice.Button == AcceptPublicERPUiButton.Deny)
        {
            Close();
            return;
        }

        ghostSystem.AddGhostHearingComponent(uid, component);
        Close();
    }
}
