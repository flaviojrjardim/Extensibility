using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Sales.Editors;
using Primavera.Logistics.Extensibility.Static;

namespace Primavera.Logistics.Extensibility.Sales
{
    public class SalesEditor : EditorVendas
    {
        public override void AntesDeGravar(ref bool Cancel, ExtensibilityEventArgs e)
        {
            base.AntesDeGravar(ref Cancel, e);

            this.DocumentoVenda.Observacoes = "O meu primeiro projeto de extensibilidade";
        }
    }
}