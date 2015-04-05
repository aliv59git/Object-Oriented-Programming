using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyRPG.Models
{
    public class Giant : Fighter, IFighter, IControllable, IWorldObject, IGatherer
    {
        private bool hasStone;
        public Giant(string name, Point position)
            : base(name, position, 0, 150, 80, 200)
        {
            this.hasStone = false;
        }

        public int AttackPoints { get; private set; }
        public int DefensePoints { get; private set; }

        public bool TryGather(IResource resource)
        {
            bool canGatter = false;
            if (resource.Type == ResourceType.Stone)
            {
                canGatter = true;
                if (!hasStone) 
                {
                    this.hasStone = true;
                    this.AttackPoints += 100;
                }
            }

            return false;
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets.FirstOrDefault(x => x.Owner != 0);
            return availableTargets.IndexOf(target);
        }
    }
}
