using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zVirtual.Connect.Client
{
    public class Datum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NodeNumber { get; set; }
        public object LastHeardFrom { get; set; }
        public string CurrentLevelText { get; set; }
        public float CurrentLevelInt { get; set; }
        public int DeviceTypeId { get; set; }
        public Type Type { get; set; }
        public Devicesettingvalues DeviceSettingValues { get; set; }
        public Devicetypesettingvalues DeviceTypeSettingValues { get; set; }
        public Values Values { get; set; }
        public Groups Groups { get; set; }
        public Storedcommands StoredCommands { get; set; }
        public string _type { get; set; }
        public string _uri { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public Options Options { get; set; }
        public string UniqueIdentifier { get; set; }
        public object Value { get; set; }
        public object Description { get; set; }
        public string CustomData1 { get; set; }
        public string CustomData2 { get; set; }
        public int SortOrder { get; set; }
        public string Help { get; set; }
    }


}
