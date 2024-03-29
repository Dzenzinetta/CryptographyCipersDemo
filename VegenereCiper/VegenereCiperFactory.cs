﻿
using ChipersUtility;

namespace VegenereCiper
{
    public static class VegenereCiperFactory
    {

        public static VegenereCiperModel CreateVegenereModel()
        {
            return new VegenereCiperModel();
        }

        public static IVegenereCiperBase CreateVegenereEncryptor()
        {
            return new VegenereEncryptor();
        }

        public static IVegenereProgramBase CreateVegenereEncryptionProgram()
        {
            return new VegenereEncryptionProgram();
        }

        public static IVegenereProgramBase CreateVegenerDecryptionProgram()
        {
            return new VegenereDecryptionProgram();
        }

        public static IConsoleMenuBase CreateVegenereCiperMenu()
        {
            return new VegenereCiperMenu();
        }
        public static IProgramStartBase CreateVegenereCiperProgram()
        {
            return new VegenereProgram();
        }

    }
}
