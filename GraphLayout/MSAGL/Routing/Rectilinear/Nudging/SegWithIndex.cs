using System.Diagnostics;
using Microsoft.Msagl.Core.Geometry;

namespace Microsoft.Msagl.Routing.Rectilinear.Nudging
{
    internal class SegWithIndex {
        internal Point[] Points;
        internal int I;//offset
    
        internal SegWithIndex(Point[] pts, int i) {
            Debug.Assert(i<pts.Length&&i>=0);
            Points = pts;
            I = i;
        }

        internal Point Start {get{return Points[I];}}
        internal Point End{ get{return Points[I+1];}}
    
        override public bool Equals(object obj) {
            var other = (SegWithIndex) obj;
            return other.Points== Points&& other.I == I;
        }

        

    }
}