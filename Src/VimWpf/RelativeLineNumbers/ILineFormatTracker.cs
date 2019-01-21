﻿using System;
using System.Windows.Media;

// Disambiguate WPF TextLine with Vim.TextLine
using WpfTextLine = System.Windows.Media.TextFormatting.TextLine;

namespace Vim.UI.Wpf.RelativeLineNumbers
{
    public interface ILineFormatTracker
    {
        Brush Background { get; }

        WpfTextLine MakeTextLine(int number);

        double NumberWidth { get; }

        bool Numbers { get; }

        bool RelativeNumbers { get; }

        bool TryClearReformatRequest();

        event EventHandler<EventArgs> VimNumbersFormatChanged;
    }
}