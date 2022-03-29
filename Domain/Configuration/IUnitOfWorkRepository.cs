using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Domain.Configuration
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        ITbl_Categoria_Documentos Tbl_Categoria_Documentos { get; }
        ITbl_Cliente Tbl_Cliente { get; }
        ITbl_Condicion Tbl_Condicion { get; }
        ITbl_Condiciones_Usuario Tbl_Condiciones_Usuario { get; }
        ITbl_Documento Tbl_Documento { get; }
        ITbl_Familiar Tbl_Familiar { get; }
        ITbl_Genero Tbl_Genero { get; }
        ITbl_Indicadores_De_Salud Tbl_Indicadores_De_Salud { get; }
        ITbl_Nivel_Indicador Tbl_Nivel_Indicador { get; }
        ITbl_Seguimiento_Condicion Tbl_Seguimiento_Condicion { get; }
        ITbl_Tipo_Documento Tbl_Tipo_Documento { get; }
        ITbl_Tipo_Sangre Tbl_Tipo_Sangre { get; }
        ITbl_Usuario Tbl_Usuario { get; }
        ITbl_Visitas_Al_Medico Tbl_Visitas_Al_Medico { get; }

        void Commit();
        void RollBack();
        void BeginTransaction();
        void ClearTracking();
        Task SaveChangesAsync();
    }
}
