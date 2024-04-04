using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace RouletteGrid;

public class GridElementControl : TemplatedControl
{
    public static readonly StyledProperty<string> BettingValueProperty = AvaloniaProperty.Register<GridElementControl, string>(
        nameof(BettingValue), "X");

    public string BettingValue
    {
        get => GetValue(BettingValueProperty);
        set => SetValue(BettingValueProperty, value);
    }
}