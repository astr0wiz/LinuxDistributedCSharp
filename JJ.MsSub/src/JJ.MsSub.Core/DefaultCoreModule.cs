using Autofac;
using JJ.MsSub.Core.Interfaces;
using JJ.MsSub.Core.Services;

namespace JJ.MsSub.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
