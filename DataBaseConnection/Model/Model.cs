using System;
using System.Data.Entity;

namespace DataBaseConnection
{
    public class Customer
    { 
        private int CustomerID { get;set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Patronymic { get; set; }
    }

    public class Project
    {
        private int ProjectID { get; set; }
        private int ProjectNumber { get; set; }
        private int ProgectName { get; set; }
        private Customer Customer { get; set; }
    }

    public class SchemeOfBuilding
    {
        private int SchemeID { get; set; }
        private double Width { get; set; }
        private double Lenght { get; set; }
        private Project ProjectNumber { get; set; }
    }

    public class InstallationPosition
    {
        private int PositionID { get; set; }
        private int Coord_X { get; set; }
        private int Coord_Y { get; set; }
        private SchemeOfBuilding Scheme { get; set; }
    }

    public class PlacmentOfModules
    {
        private int PlacementID { get; set; }
        private InstallationPosition Position { get; set; }
        private ModelsOfModules Model { get; set; }
    }

    public class ModelsOfModules
    {
        private int ModuleID { get; set; }
        private string ModelName { get; set; }
        private string ModelRadius { get; set; }
    }
}
