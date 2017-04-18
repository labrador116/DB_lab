using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DataBaseConnection
{
    public class Customer
    {
        [Key]
        public int CustomerId { get;set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public virtual List<Project> Projects { get; set; }
    }

    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public int ProjectNumber { get; set; }
        public int ProgectName { get; set; }
        public virtual Customer Customer { get; set; }
    }

    public class SchemeOfBuilding
    {
        [Key]
        public int SchemeId { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }
        public virtual Project ProjectNumber { get; set; }
        public virtual List<InstallationPosition> Positions { get; set; }
    }

    public class InstallationPosition
    {
        [Key]
        public int PositionId { get; set; }
        public int Coord_X { get; set; }
        public int Coord_Y { get; set; }
        public virtual SchemeOfBuilding Scheme { get; set; }
    }

    public class PlacmentOfModules
    {
        [Key]
        public int PlacementId { get; set; }
        public InstallationPosition Position { get; set; }
        public virtual ModelsOfModules Model { get; set; }
    }

    public class ModelsOfModules
    {
        [Key]
        public int ModuleId { get; set; }
        public string ModelName { get; set; }
        public string ModelRadius { get; set; }
    }
}
