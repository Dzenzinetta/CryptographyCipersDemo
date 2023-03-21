﻿using ChipersUtility;

namespace AffineCiper
{
    public interface IAffineProcessBase
    {
        IAffineKeyBase AdditiveKeyObject { get; set; }

        IAffineKeyBase MultiplicativeKeyObject { get; set; }

        IAffineCryptographyTypeBase AffineProcessObject { get; set; }

        IAffineBaseModel Model { get; set; }

        ITextInput ConsoleInput { get; set; }

        public void AffineMainProcess();

    }
}