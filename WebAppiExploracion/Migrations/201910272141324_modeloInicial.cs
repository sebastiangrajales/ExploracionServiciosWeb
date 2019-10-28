namespace WebAppiExploracion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tareas",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        nombre = c.String(),
                        minutosLiderEquipo = c.Int(nullable: false),
                        minutosLiderPlaneacion = c.Int(nullable: false),
                        minutosLiderSoporte = c.Int(nullable: false),
                        minutosLiderCalidad = c.Int(nullable: false),
                        minutosLiderDesarrollo = c.Int(nullable: false),
                        minutosPlaneados = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        nombre = c.String(),
                        apellidos = c.String(),
                        rol = c.String(),
                        nombreEquipo = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Tareas");
        }
    }
}
