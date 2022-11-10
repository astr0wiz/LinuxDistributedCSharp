using Autofac;
using JJ.MrPub.Core.Interfaces;
using JJ.MrPub.Core.Services;

namespace JJ.MrPub.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
