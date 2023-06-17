namespace Software2KnowledgeCheck1
{
    class CityBuilder
    {
        private BuildingConstruction _buildingConstruction = new BuildingConstruction();

        public void CreateBuilding<T>(City city, T building) where T : Building
        {
            // Initialize Repos
            var materialRepo = new MaterialsRepo();
            var permitRepo = new ZoningAndPermitRepo();

            // Get materials and Permit
            var materialsNeeded = materialRepo.GetMaterials();
            var permit = permitRepo.GetPermit();
            var zoning = permitRepo.ZoningApproves();

            // Construct Building
            var buildingWasMade = _buildingConstruction.ConstructBuilding<T>(materialsNeeded, permit, zoning);

            if (buildingWasMade)
            {
                city.Buildings.Add(building);
            }
        }
    }
}
