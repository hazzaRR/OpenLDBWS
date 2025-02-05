using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


[XmlRoot(ElementName = "GetStationBoardResult")]
public class StationBoardWithDetails
{
        [XmlElement(ElementName = "generatedAt", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string GeneratedAt { get; set; } = "";

        [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string LocationName { get; set; } = "";

        [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string Crs { get; set; } = "";

        [XmlElement(ElementName = "filterLocationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string FilterLocationName { get; set; } = "";

        [XmlElement(ElementName = "filtercrs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public string FilterCrs { get; set; } = "";

        [XmlElement(ElementName = "platformAvailable", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public bool PlatformAvailable { get; set; } = false;

        [XmlArray("TrainServices", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        // [XmlArrayItem("Service", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public List<Service> Services { get; set; } = new List<Service>();
}