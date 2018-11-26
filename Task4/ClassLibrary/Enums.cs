using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum PedestrianStatus : int
    {
        death = 0,
        uncosious = 1,
        healthy = 2
    }
    public enum CarStatus : int
    {
        explosed = 0,
        broken = 1,
        OnTheRun = 2
    }
}
