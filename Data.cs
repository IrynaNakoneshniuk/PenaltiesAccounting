using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PenaltiesAccounting
{
    [Serializable]
    public class Data:ISerializable
    {
        public List<Individual> ?users;
        public List<ExecutiveAgency> ?executiveAgency;
        public List<AdministrativeFine> ? administrativePenalties;
        public List<TrafficRuelsPenalty> ?trafficRuelsPenalty;
        public Data(List<Individual>? users, List<ExecutiveAgency>? executiveAgency, List<AdministrativeFine>? AdministrativePenalties,
            List<TrafficRuelsPenalty> TrafficRuelsPenalty)
        {
            this.users = users;
            this.executiveAgency = executiveAgency;
            this.trafficRuelsPenalty = TrafficRuelsPenalty;
            this.administrativePenalties = AdministrativePenalties;
        }
        public Data()
        {
            users = new List<Individual>();
            executiveAgency = new List<ExecutiveAgency>();
            trafficRuelsPenalty= new List<TrafficRuelsPenalty>();
            administrativePenalties = new List<AdministrativeFine>();
        }
        public Data(Data data)
        {
            this.users = data.users;
            this.administrativePenalties=data.administrativePenalties;
            this.trafficRuelsPenalty=data.trafficRuelsPenalty;
            this.executiveAgency=data.executiveAgency;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("users:", users);
            info.AddValue("executiveAgency:", executiveAgency);
            info.AddValue("administrativePenaltie:", administrativePenalties);
            info.AddValue("trafficRuelsPenalt:", trafficRuelsPenalty);
        }
    }
}
