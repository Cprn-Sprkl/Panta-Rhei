using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared._Floof.Ghost.UI
{
    [Serializable, NetSerializable]
    public enum AcceptPublicERPUiButton
    {
        Deny,
        Accept,
    }

    [Serializable, NetSerializable]
    public sealed class AcceptPublicERPChoiceMessage : EuiMessageBase
    {
        public readonly AcceptPublicERPUiButton Button;

        public AcceptPublicERPChoiceMessage(AcceptPublicERPUiButton button)
        {
            Button = button;
        }
    }
}
