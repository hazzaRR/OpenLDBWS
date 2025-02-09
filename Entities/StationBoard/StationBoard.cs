using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


[XmlRoot(ElementName = "GetStationBoardResult")]
public class StationBoard
{
        [XmlElement(ElementName = "generatedAt", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string GeneratedAt { get; set; } = "";

        [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string LocationName { get; set; } = "";

        [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Crs { get; set; } = "";

        [XmlArray(ElementName = "nrccMessages", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        [XmlArrayItem(ElementName = "message", Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
        public List<string> NrccMessages { get; set; } = [];

        [XmlElement(ElementName = "filterLocationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string FilterLocationName { get; set; } = "";

        [XmlElement(ElementName = "filtercrs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string FilterCrs { get; set; } = "";

        [XmlElement(ElementName = "platformAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool PlatformAvailable { get; set; } = false;

        [XmlArray(ElementName = "trainServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        [XmlArrayItem(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        public List<Service> TrainServices { get; set; } = [];

        [XmlArray(ElementName = "busServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        [XmlArrayItem(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        public List<Service> BusServices { get; set; } = [];

        [XmlArray(ElementName = "ferryServices", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        [XmlArrayItem(ElementName = "service", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
        public List<Service> FerryServices { get; set; } = [];
}