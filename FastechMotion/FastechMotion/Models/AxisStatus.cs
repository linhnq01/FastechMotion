using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastechMotion.Models
{
    public class AxisStatus
    {
        public bool ErrorAll { get; set; }
        public bool HWLimitPlus { get; set; }
        public bool HWLimitMinus { get; set; }
        public bool SWLimitPlus { get; set; }
        public bool SWLimitMinus { get; set; }
        public bool ErrPosOverflow { get; set; }
        public bool ErrOverCurrent { get; set; }
        public bool ErrOverSpeed { get; set; }
        public bool ErrPosTracking { get; set; }
        public bool ErrOverload { get; set; }
        public bool ErrOverheat { get; set; }
        public bool ErrBackEMF { get; set; }
        public bool ErrMotorPower { get; set; }
        public bool ErrInposition { get; set; }
        public bool EmgStop { get; set; }
        public bool SlowStop { get; set; }
        public bool OrgReturning { get; set; }
        public bool Inposition { get; set; }
        public bool ServoOn {  get; set; }
        public bool AlarmReset { get; set;}
        public bool PTStopped { get; set; }
        public bool OriginSensor {  get; set; }
        public bool ZPulse { get; set; }
        public bool OrgRetOK { get; set; }
        public bool MotionDIR {  get; set; }
        public bool Motioning {  get; set; }
        public bool MotionPause {  get; set; }
        public bool MotionAccel {  get; set; }
        public bool MotionDecel { get; set;}
        public bool MotionConst {  get; set; }
    }
}
