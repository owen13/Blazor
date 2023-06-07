using System;
using Data;
using MapsterMapper;
using Models;

namespace Data
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository Actors { get; }
        
        IComputerRepository Computers { get; }
        IRamRepository Rams { get; }
        IGraphicsCardRepository GraphicsCards { get; }
        IUsbQuantityRepository UsbCounts { get; }
        IHardDriveRepository HardDrives { get; }
        
        IProcessorRepository Processors { get; }
        int SubmitChanges();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrionDbContext _dbContext;

        public UnitOfWork(OrionDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;

            Actors = new ActorRepository(_dbContext);
            
            Computers = new ComputerRepository(_dbContext);
            Rams = new RamRepository(_dbContext);
            GraphicsCards = new GraphicsCardRepository(_dbContext);
            HardDrives = new HardDriveRepository(_dbContext);
            UsbCounts = new UsbQuantityRepository(_dbContext);
            Processors = new ProcessorRepository(_dbContext);
        }

        public IActorRepository Actors { get; private set; }

        public IComputerRepository Computers { get; private set; }
        public IRamRepository Rams { get; private set; }
        public IGraphicsCardRepository GraphicsCards { get; }
        public IHardDriveRepository HardDrives { get; }
        public IUsbQuantityRepository UsbCounts { get; }
        public IProcessorRepository Processors { get; }

        public int SubmitChanges()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}