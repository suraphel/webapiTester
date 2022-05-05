using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using webapi002.Data.Model;

namespace webapi002.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder )
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            { 
               var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.CustomerInfos.Any())
                {
                    context.CustomerInfos.AddRange(
                        new CustomerInfo()
                    {
                            name = "MSuraphel",
                            address = "Bole",
                            city = "AA",
                            birthday = DateTime.Now.AddYears(-20),

                            //producksjonsplassid = 100000,
                            //kommunenummer =1111,
                            //gaardsnummer =2222 ,
                            //bruksnummer = 33333,
                            //opretterdato = DateTime.Now.AddYears(-40)

                     
                    },
                    (new CustomerInfo()
                    {

                        //producksjonsplassid = 70000,
                        //kommunenummer = 110011,
                        //gaardsnummer = 220022,
                        //bruksnummer = 3300333,
                        //opretterdato = DateTime.Now.AddYears(-40),
                        name = "msuraphel",
                        address = "bole",
                        city = "aa",
                        birthday = DateTime.Now.AddYears(-40),

                    }));

                    context.SaveChanges();
                }
            
            }
        }

    }
}
