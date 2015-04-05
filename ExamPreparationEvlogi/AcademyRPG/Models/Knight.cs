using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyRPG.Models
{
    public class Knight : Fighter, IFighter, IControllable, IWorldObject
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner, 100, 100, 100)
        {
        }


        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var targetFirst = availableTargets.FirstOrDefault(x => x.Owner != 0 && x.Owner != this.Owner);
            return availableTargets.IndexOf(targetFirst);
        }
    }
}
