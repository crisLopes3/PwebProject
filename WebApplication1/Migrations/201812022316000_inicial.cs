namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ramo = c.Int(nullable: false),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cadeiras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoDisciplina = c.Int(nullable: false),
                        Nota = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Propostas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        LocalEstagio = c.String(nullable: false),
                        TipoProposta = c.Int(),
                        Ramo = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        Objetivos = c.String(),
                        Comissao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comissao", t => t.Comissao_Id)
                .Index(t => t.Comissao_Id);
            
            CreateTable(
                "dbo.Comissao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Docentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Comissao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comissao", t => t.Comissao_Id)
                .Index(t => t.Comissao_Id);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CadeiraAlunoes",
                c => new
                    {
                        Cadeira_Id = c.Int(nullable: false),
                        Aluno_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cadeira_Id, t.Aluno_Id })
                .ForeignKey("dbo.Cadeiras", t => t.Cadeira_Id, cascadeDelete: true)
                .ForeignKey("dbo.Alunos", t => t.Aluno_Id, cascadeDelete: true)
                .Index(t => t.Cadeira_Id)
                .Index(t => t.Aluno_Id);
            
            CreateTable(
                "dbo.PropostaAlunoes",
                c => new
                    {
                        Proposta_Id = c.Int(nullable: false),
                        Aluno_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Proposta_Id, t.Aluno_Id })
                .ForeignKey("dbo.Propostas", t => t.Proposta_Id, cascadeDelete: true)
                .ForeignKey("dbo.Alunos", t => t.Aluno_Id, cascadeDelete: true)
                .Index(t => t.Proposta_Id)
                .Index(t => t.Aluno_Id);
            
            CreateTable(
                "dbo.DocentePropostas",
                c => new
                    {
                        Docente_Id = c.Int(nullable: false),
                        Proposta_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Docente_Id, t.Proposta_Id })
                .ForeignKey("dbo.Docentes", t => t.Docente_Id, cascadeDelete: true)
                .ForeignKey("dbo.Propostas", t => t.Proposta_Id, cascadeDelete: true)
                .Index(t => t.Docente_Id)
                .Index(t => t.Proposta_Id);
            
            CreateTable(
                "dbo.EmpresaPropostas",
                c => new
                    {
                        Empresa_Id = c.Int(nullable: false),
                        Proposta_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Empresa_Id, t.Proposta_Id })
                .ForeignKey("dbo.Empresas", t => t.Empresa_Id, cascadeDelete: true)
                .ForeignKey("dbo.Propostas", t => t.Proposta_Id, cascadeDelete: true)
                .Index(t => t.Empresa_Id)
                .Index(t => t.Proposta_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpresaPropostas", "Proposta_Id", "dbo.Propostas");
            DropForeignKey("dbo.EmpresaPropostas", "Empresa_Id", "dbo.Empresas");
            DropForeignKey("dbo.Propostas", "Comissao_Id", "dbo.Comissao");
            DropForeignKey("dbo.DocentePropostas", "Proposta_Id", "dbo.Propostas");
            DropForeignKey("dbo.DocentePropostas", "Docente_Id", "dbo.Docentes");
            DropForeignKey("dbo.Docentes", "Comissao_Id", "dbo.Comissao");
            DropForeignKey("dbo.PropostaAlunoes", "Aluno_Id", "dbo.Alunos");
            DropForeignKey("dbo.PropostaAlunoes", "Proposta_Id", "dbo.Propostas");
            DropForeignKey("dbo.CadeiraAlunoes", "Aluno_Id", "dbo.Alunos");
            DropForeignKey("dbo.CadeiraAlunoes", "Cadeira_Id", "dbo.Cadeiras");
            DropIndex("dbo.EmpresaPropostas", new[] { "Proposta_Id" });
            DropIndex("dbo.EmpresaPropostas", new[] { "Empresa_Id" });
            DropIndex("dbo.DocentePropostas", new[] { "Proposta_Id" });
            DropIndex("dbo.DocentePropostas", new[] { "Docente_Id" });
            DropIndex("dbo.PropostaAlunoes", new[] { "Aluno_Id" });
            DropIndex("dbo.PropostaAlunoes", new[] { "Proposta_Id" });
            DropIndex("dbo.CadeiraAlunoes", new[] { "Aluno_Id" });
            DropIndex("dbo.CadeiraAlunoes", new[] { "Cadeira_Id" });
            DropIndex("dbo.Docentes", new[] { "Comissao_Id" });
            DropIndex("dbo.Propostas", new[] { "Comissao_Id" });
            DropTable("dbo.EmpresaPropostas");
            DropTable("dbo.DocentePropostas");
            DropTable("dbo.PropostaAlunoes");
            DropTable("dbo.CadeiraAlunoes");
            DropTable("dbo.Empresas");
            DropTable("dbo.Docentes");
            DropTable("dbo.Comissao");
            DropTable("dbo.Propostas");
            DropTable("dbo.Cadeiras");
            DropTable("dbo.Alunos");
        }
    }
}
