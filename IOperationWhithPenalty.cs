using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltiesAccounting
{
      interface IOperationWhithPenalty
    {
        void AddPenalty(IPenalty penalty, Data data);
        void RemovePenalty(IPenalty penalty,Data data);
        List<IPenalty> GetPenalty(Data data);
        IPenalty Create();
    }
    internal  class OperationTrafficPenalty : IOperationWhithPenalty
    {
        public void AddPenalty(IPenalty penalty, Data data)
        {
            data.trafficRuelsPenalty.Add((TrafficRuelsPenalty)penalty);
        }

        public IPenalty Create()
        {
            CraeteTrafficPenalty craeteTrafficPenalty = new CraeteTrafficPenalty();
            IPenalty trafficRuelsPenalty = craeteTrafficPenalty.CreatePenalty();
            return trafficRuelsPenalty;
        }

        public List<IPenalty> GetPenalty(Data data)
        {
            if (data.trafficRuelsPenalty != null)
            {
               IEnumerable<IPenalty> penaltyTraffic = from i in data.trafficRuelsPenalty
                                     from k in data.users
                                     where i.IdentifyCode == k.IdentificationCode
                                     select i;
                List<IPenalty> list =new List<IPenalty> ();
                foreach (var i in penaltyTraffic)
                {
                    list.Add(i);
                }
                return list;
            }
            else
            {
                throw new NullReferenceException("List TrafficRuelsPenalty is empty!");
            }
        }

        public void RemovePenalty(IPenalty penalty, Data data)
        {
            data.trafficRuelsPenalty.Remove((TrafficRuelsPenalty)penalty);
        }
    }
    internal class OperationAdministrativeFine : IOperationWhithPenalty
    {
        public void AddPenalty(IPenalty penalty, Data data)
        {
            data.administrativePenalties.Add((AdministrativeFine)penalty);
        }

        public List<IPenalty> GetPenalty( Data data)
        {
            if (data.administrativePenalties != null)
            {
                IEnumerable < IPenalty > penaltyAdministrative = from i in data.administrativePenalties
                                     from k in data.users
                                     where i.IdentifyCode == k.IdentificationCode
                                     select i;
                List<IPenalty> list = new List<IPenalty>();
                foreach (var i in penaltyAdministrative)
                {
                    list.Add(i);
                }
                return list;
            }
            else
            {
                throw new NullReferenceException("List AdministrativeFine is empty!");
            }
        }
        public void RemovePenalty(IPenalty penalty, Data data)
        {
            data.administrativePenalties.Remove((AdministrativeFine)penalty);
        }
        public IPenalty Create()
        {
            CreateAdministrativeFine createAdministrativeFine = new CreateAdministrativeFine();
            IPenalty penalty = createAdministrativeFine.CreatePenalty();
            return penalty;
        }
    }
}
