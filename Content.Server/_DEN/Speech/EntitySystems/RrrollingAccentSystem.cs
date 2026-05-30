using Content.Server._DEN.Speech.Components;
using System.Text.RegularExpressions;
using Content.Shared.Speech;
using Robust.Shared.Random;
using Content.Shared.Mobs;
using System.Linq;
namespace Content.Server._DEN.Speech.EntitySystems;

public sealed class RrrollingAccentSystem : EntitySystem // Euphoria | Changed from TajaranAccentSystem as it will not be base to Tajaran here.
{
    [Dependency] private readonly IRobustRandom _random = default!;
    private static readonly Regex RegexLowerR = new("r");
    private static readonly Regex RegexUpperR = new("R");
    private static readonly string[] Replacements = ["r", "rr", "rrr"];

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<RrrollingAccentComponent, AccentGetEvent>(OnAccent); // Euphoria | Change from TajaranAccentComponent
    }


    private void OnAccent(EntityUid uid, RrrollingAccentComponent comp, AccentGetEvent args) // Euphoria | Change from TajaranAccentComponent
    {
        var message = args.Message;
        var words = message.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = RegexLowerR.Replace(words[i], Replacements[_random.Next(3)]);
            words[i] = RegexUpperR.Replace(words[i], Replacements[_random.Next(3)].ToUpper());
        }
        args.Message = string.Join(' ', words);
    }
}
