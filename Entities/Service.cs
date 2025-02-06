using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class Service 
{

    [XmlElement(ElementName = "std", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string Std {get; set;}

    [XmlElement(ElementName = "etd", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string Etd {get; set;} = "";

    [XmlElement(ElementName = "platform", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string Platform {get; set;} = "";

    [XmlElement(ElementName = "operator", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string Operator {get; set;} = "";

    [XmlElement(ElementName = "operatorCode", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string OperatorCode {get; set;} = "";

    [XmlElement(ElementName = "serviceType", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string ServiceType {get; set;} = "";

    [XmlElement(ElementName = "length", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public int Length {get; set;} = 0;

    [XmlElement(ElementName = "serviceID", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string ServiceId {get; set;} = "";

    [XmlElement(ElementName = "origin", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public required Station Origin {get; set;}

    [XmlElement(ElementName = "destination", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public required Station Destination {get; set;}
    
    [XmlElement("formation", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
    public required Formation Formation {get; set;}

    [XmlElement("subsequentCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/types")]
    public required SubsequentCallingPoints SubsequentCallingPoints {get; set;}

}
