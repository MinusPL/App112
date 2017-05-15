using System;

namespace App112
{
    public interface IDeviceServiceInfo
    {
        string ConvertToDeviceShortDateFormat(DateTime inputDateTime);
        string ConvertToDeviceTimeFormat(DateTime inputDateTime);
    }
}
