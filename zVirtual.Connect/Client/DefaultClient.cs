//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using zVirtual.Connect.Contracts;

//namespace zVirtual.Connect.Client
//{
//    public class DefaultClient : IWebApiClient
//    {
//        public String Host { get; set; }
//        public String Token { get; set; }
//        public DeviceResult GetDevices()
//        {
//            string url = string.Format("{0}/v2/DeviceCommand", Host);
//            System.Net.WebClient wc = new WebClient();
//            wc.Headers.Add("X-zvsToken", Token);
//            wc.Headers.Add("Content-Type", "application/json");
//            var str = wc.DownloadString(url);
//            return JsonConvert.DeserializeObject<DeviceResult>(str);
//        }

//        public PostDeviceCommandResult PostDeviceCommand(Int32 deviceId, Int32 commandId, String value)
//        {
//            throw new NotImplementedException();
//        }

//        public DeviceCommandsResult GetDeviceCommands(Int32 deviceId)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
