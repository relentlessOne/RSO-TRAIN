using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Trainz
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        CompositeType fetchData();

        [OperationContract]
        string findConnection(CompositeType CT,string cityA, string cityB,string startDate, string stopDate);

        [OperationContract]
        bool checkIfStartCityExists(CompositeType CT, string clientData);

        [OperationContract]
        bool checkIfStopCityExists(CompositeType CT, string clientData);


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";
        string[][] start = null;
        string[][] stop = null;
        string[] startTime = null;
        string[] stopTime = null;

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string[][] Start
        {
            get { return start; }
            set { start = value; }
        }

        [DataMember]
        public string[][] Stop
        {
            get { return stop; }
            set { stop = value; }
        }

        [DataMember]
        public string[] StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        [DataMember]
        public string[] StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
