using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zVirtual.Connect.Client;

namespace zVirtual.Connect.Contracts
{
    public interface IWebApiClient
    {
        string Host { get; set; }
        string Token { get; set; }
        DeviceResult GetDevices();
        DeviceCommandsResult GetDeviceCommands(int deviceId);
        PostDeviceCommandResult PostDeviceCommand(int deviceId, int commandId, string value);

    }
}
