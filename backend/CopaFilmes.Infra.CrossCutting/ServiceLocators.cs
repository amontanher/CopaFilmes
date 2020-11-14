using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Infra.CrossCutting
{
    public static class ServiceLocators
    {
        private static IDictionary<string, Object> services = new Dictionary<string, object>();

        public static T Get<T>(string name) => (T)services[name];      

        public static bool Has(string name) => services.ContainsKey(name);

        public static void Register<T>(string name, T service) {
            services.Add(new KeyValuePair<string, Object>(name, service));
        }
    }
}
