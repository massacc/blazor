using System.ComponentModel;
using System.Net;
using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;

namespace BlazorApp.Models
{
    [XmlRoot("shipInPort")]
    public class PortData
    {
        [XmlAttribute("Time")]
        public string Time { get; set; }

        [XmlElement("Visit")]
        public ShipData[]? Ships { get; set; }


    }
    
    public class ShipData
    {
        public string? CallId { get; set; }
        

        public string? PortOfCall { get; set; }
        

        public string? AgentArrival { get; set; }
        

        public string? AgentDeparture{ get; set; }
        

        public string? ETA { get; set; }


        public string? ATA { get; set; }


        public string? ETD { get; set; }


        public string? ATD {get; set;}
        

        public string? LastPort { get; set; }

        public string? NextPort { get; set; }


        public string? VisitStatusID { get; set; }


        public string? VisitStatus { get; set; }


        public string? imo { get; set; }
        

        public string? VesselName { get; set; }

        public string? VesselType { get; set; }


        public string? VesselFlag { get; set; }


        public string? VesselStatusID { get; set; }


        public string? VesselStatus { get; set; }


        public string? Quay { get; set; }


        public string? AnchorageArea { get; set; }
        
    }
}
