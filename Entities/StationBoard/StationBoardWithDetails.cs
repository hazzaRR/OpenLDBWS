using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


[XmlRoot(ElementName = "GetStationBoardResult")]
public class StationBoardWithDetails: StationBoard
{
        [XmlArray(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        [XmlArrayItem(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        public new List<ServiceWithCallingPoints> TrainServices { get; set; } = [];

        [XmlArray(ElementName = "busServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        [XmlArrayItem(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        public new List<ServiceWithCallingPoints> BusServices { get; set; } = [];

        [XmlArray(ElementName = "ferryServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        [XmlArrayItem(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        public new List<ServiceWithCallingPoints> FerryServices { get; set; } = [];
}