using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace Business
{
    public class Registrar
    {
        public static void RegistraComponentes()
        {
            var container = new UnityContainer();
            container.RegisterType<ICalculo, Calculo>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
