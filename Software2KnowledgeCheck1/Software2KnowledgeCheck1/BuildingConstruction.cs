using System.Collections.Generic;

namespace Software2KnowledgeCheck1
{
    class BuildingConstruction
    {
        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

