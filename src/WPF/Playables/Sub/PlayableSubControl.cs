﻿using System.Windows.Controls;
using RCAudioPlayer.Core.Players;

namespace RCAudioPlayer.WPF.Playables.Sub
{
    public abstract class PlayableSubControl : UserControl
    {
        public IPlayable Playable { get; }

        public PlayableSubControl(IPlayable playable)
        {
            Playable = playable;
        }
    }
}