using System.Xml.Serialization;

namespace WebApplication1.Models
{
    public enum TipoDisciplina
    {
        [XmlEnum("Análise Matemática I")]
        AnaliseMatematicaI,
        [XmlEnum("Análise Matemática II")]
        AnaliseMatematicaII
    }
}