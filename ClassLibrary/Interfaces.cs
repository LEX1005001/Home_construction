using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IPart
    {
        void Build();
    }
    public interface IWorker
    {
        void DoWork(List<IPart> parts);
    }
    
}
