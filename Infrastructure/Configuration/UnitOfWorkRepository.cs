using System;
using Domain.Configuration;
using Microsoft.EntityFrameworkCore.Storage;
using Domain.Repository;
using System.Threading.Tasks;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repositories;

namespace Infrastructure.Configuration
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private IDbContext _dbContext;
        private IDbContextTransaction _dbContextTransaction;

        public IEmployeeRepository EmployeeRepository { get; private set; }

        public ITbl_Categoria_Documentos Tbl_Categoria_Documentos { get; private set; }

        public ITbl_Cliente Tbl_Cliente { get; private set; }

        public ITbl_Condicion Tbl_Condicion { get; private set; }

        public ITbl_Condiciones_Usuario Tbl_Condiciones_Usuario { get; private set; }

        public ITbl_Documento Tbl_Documento { get; private set; }

        public ITbl_Familiar Tbl_Familiar { get; private set; }

        public ITbl_Genero Tbl_Genero { get; private set; }

        public ITbl_Indicadores_De_Salud Tbl_Indicadores_De_Salud { get; private set; }

        public ITbl_Nivel_Indicador Tbl_Nivel_Indicador { get; private set; }

        public ITbl_Seguimiento_Condicion Tbl_Seguimiento_Condicion { get; private set; }

        public ITbl_Tipo_Documento Tbl_Tipo_Documento { get; private set; }

        public ITbl_Tipo_Sangre Tbl_Tipo_Sangre { get; private set; }

        public ITbl_Usuario Tbl_Usuario { get; private set; }

        public ITbl_Visitas_Al_Medico Tbl_Visitas_Al_Medico { get; private set; }

        public UnitOfWorkRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            EmployeeRepository = new EmployeeRepository(dbContext);
            Tbl_Categoria_Documentos = new Tbl_Categoria_Documentos_Repository(dbContext);
            Tbl_Cliente = new Tbl_Cliente_Repository(dbContext);
            Tbl_Condicion = new Tbl_Condicion_Repository(dbContext);
            Tbl_Condiciones_Usuario = new Tbl_Condiciones_Usuario_Repository(dbContext);
            Tbl_Documento = new Tbl_Documento_Repository(dbContext);
            Tbl_Familiar = new Tbl_Familiar_Repository(dbContext);
            Tbl_Genero = new Tbl_Genero_Repository(dbContext);
            Tbl_Indicadores_De_Salud = new Tbl_Indicadores_De_Salud_Repository(dbContext);
            Tbl_Nivel_Indicador = new Tbl_Nivel_Indicador_Repository(dbContext);
            Tbl_Seguimiento_Condicion = new Tbl_Seguimiento_Condicion_Repository(dbContext);
            Tbl_Tipo_Documento = new Tbl_Tipo_Documento_Repository(dbContext);
            Tbl_Tipo_Sangre = new Tbl_Tipo_Sangre_Repository(dbContext);
            Tbl_Usuario = new Tbl_Usuario_Repository(dbContext);
            Tbl_Visitas_Al_Medico = new Tbl_Visitas_Al_Medico_Repository(dbContext);
        }

        public void BeginTransaction()
        {
            _dbContextTransaction = ((ApplicationContext)_dbContext).Database.BeginTransaction();
        }

        public void ClearTracking()
        {
            ((ApplicationContext)_dbContext).ChangeTracker.Clear();
        }

        public void Commit()
        {
            try
            {
                _dbContextTransaction?.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error  en {nameof(UnitOfWorkRepository)}.{CallerMember.GetNameMethod()}: {ex.Message}", ex);
            }
        }

        private void Dispose(bool disposing)
        {
            if (!disposing || _dbContext == null) return;
            ((DbContext)_dbContext).Dispose();
            _dbContext = null;
        }

        public void RollBack()
        {
            _dbContextTransaction?.Rollback();
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error  en {nameof(UnitOfWorkRepository)}.{CallerMember.GetNameMethod()}: {ex.Message}", ex);
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

    }
}
