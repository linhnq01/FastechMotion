using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastechMotion.Models
{
    public class SingleMove
    {
        /// <summary>
        /// Target Position
        /// </summary>
        public int CmdPos { get; set; }

        /// <summary>
        /// Start Speed
        /// </summary>
        public int StartSpeed { get; set; }
        /// <summary>
        /// Move Speed
        /// </summary>
        public int MoveSpeed {  get; set; }

        /// <summary>
        /// Time value of acceleration / deceleration section during movement
        /// </summary>
        public int AccelTime { get; set; }

        /// <summary>
        /// DecelTime
        /// </summary>
        public int DecelTime { get; set; }
    }
}
