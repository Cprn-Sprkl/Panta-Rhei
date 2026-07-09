using Content.Client.Eui;
using Content.Shared._Floof.Ghost.UI;
using JetBrains.Annotations;
using Robust.Client.Graphics;

namespace Content.Client._Floof.UI;

[UsedImplicitly]
public sealed class AcceptPublicERPEui : BaseEui
{
    private readonly AcceptPublicERPWindow _window;

    public AcceptPublicERPEui()
    {
        _window = new AcceptPublicERPWindow();
        _window.DenyButton.OnPressed += _ =>
        {
            SendMessage(new AcceptPublicERPChoiceMessage(AcceptPublicERPUiButton.Deny));
            _window.Close();
        };
        _window.AcceptButton.OnPressed += _ =>
        {
            SendMessage(new AcceptPublicERPChoiceMessage(AcceptPublicERPUiButton.Accept));
            _window.Close();
        };
    }
    public override void Opened()
    {
        IoCManager.Resolve<IClyde>().RequestWindowAttention();
        _window.OpenCentered();
    }
    public override void Closed()
    {
        _window.Close();
    }
}
