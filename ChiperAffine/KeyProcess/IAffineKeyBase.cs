﻿using ChipersUtility;

namespace AffineCiper
{
    public interface IAffineKeyBase
    {
        int InputKey { get; set; }
        string PromtMessage { get; }
        public int KeyProcess();
        bool IsKeyValid();
    }
}