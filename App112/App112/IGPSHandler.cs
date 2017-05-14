using System;

namespace App112
{
    public interface IGPSHandler
    {
        bool IsGPSEnabled();
        void OpenGPSSettings();
       // string GetLocation();
    }
}
