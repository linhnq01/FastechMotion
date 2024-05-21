using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastechMotion.Models
{
    public class PositionStatus
    {
        public int CmdPos {  get; set; }
        public int ActualPos {  get; set; }
        public int ActualVel { get; set; }
        public int PosError { get; set;}
    }
}
