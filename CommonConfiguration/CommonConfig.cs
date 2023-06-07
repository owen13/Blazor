using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Data;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Models.Enums;
using Services;

namespace CommonConfiguration
{
    public static class CommonConfig
    {
        public static void Setup(IServiceCollection services)
        {
            SetupMapping(services);
            SetupRepositories(services);
            SetupServices(services);
        }

        private static void SetupMapping(IServiceCollection services)
        {
            IList<IRegister> mappingRegistrations = TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
            TypeAdapterConfig typeAdapterConfig = new TypeAdapterConfig();
            mappingRegistrations.ToList().ForEach(register => register.Register(typeAdapterConfig));
            Mapper mapperConfig = new Mapper(typeAdapterConfig);
            services.AddSingleton<IMapper>(mapperConfig);
            services.AddSingleton<ICodeGenerationRegister, CodeGenerationRegister>();

            TypeAdapterConfig<Computer, ComputerDto>
                .NewConfig()
                .Map(dest => dest.UsbCounts.Usb2,
                    src => src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB2) != null
                        ? src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB2).Quantity
                        : 0)
                .Map(dest => dest.UsbCounts.Usb3,
                    src => src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB3) != null
                        ? src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB3).Quantity
                        : 0)
                .Map(dest => dest.UsbCounts.UsbC,
                    src => src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USBC) != null
                        ? src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USBC).Quantity
                        : 0)
                ;

            TypeAdapterConfig<Computer, ComputerWithDescriptionsDto>
                .NewConfig()

                // BASE - Can this be mapped from ComputerDto map?
                .Map(dest => dest.UsbCounts.Usb2,
                    src => src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB2) != null
                        ? src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB2).Quantity
                        : 0)
                .Map(dest => dest.UsbCounts.Usb3,
                    src => src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB3) != null
                        ? src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USB3).Quantity
                        : 0)
                .Map(dest => dest.UsbCounts.UsbC,
                    src => src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USBC) != null
                        ? src.Usbs.SingleOrDefault(x => x.UsbType == EUsbType.USBC).Quantity
                        : 0)

                .Map(dest => dest.RamDescription, src => $"{src.Ram.Size} {src.Ram.Unit}")
                .Map(dest => dest.GraphicsCardDescription, src => src.GraphicsCard.Name)
                .Map(dest => dest.HardDriveDescription,
                    src => $"{src.HardDrive.Size} {src.HardDrive.StorageUnit} {src.HardDrive.HardDriveType}")
                .Map(dest => dest.ProcessorDescription, src => src.Processor.Name)
                ;
        }

        private static void SetupRepositories(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IActorRepository, ActorRepository>();
            services.AddTransient<IComputerRepository, ComputerRepository>();
        }

        private static void SetupServices(IServiceCollection services)
        {
            services.AddTransient<IComputerPartsViewModelService, ComputerPartsViewModelService>();
            services.AddTransient<IComputerService, ComputerService>();
            services.AddTransient<IGraphicsCardService, GraphicsCardService>();
            services.AddTransient<IHardDriveService, HardDriveService>();
            services.AddTransient<IProcessorService, ProcessorService>();
            services.AddTransient<IRamService, RamService>();
            services.AddTransient<IUsbUpdaterService, UsbUpdaterService>();
        }
    }
}