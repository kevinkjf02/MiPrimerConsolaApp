using System;
using System.Collections.Generic;
namespace Arbol.app
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaPolitica areaPolitica = new AreaPolitica
            {

                nombre = "Ecuador",
                TipoArea = TipoArea.Pais,
                AreaPoliticas = new List<AreaPolitica>
                {
                new AreaPolitica
                        {
                            nombre = "Pichincha",
                            TipoArea = TipoArea.Provincia,
                            AreaPoliticas = new List<AreaPolitica>
                            {
                                new AreaPolitica
                                {
                                    nombre = "Quito",
                                    TipoArea = TipoArea.Canton,
                                    AreaPoliticas = new List<AreaPolitica>
                                    {
                                        new AreaPolitica
                                        {
                                            nombre = "La Merced",
                                            TipoArea = TipoArea.Parroquia,
                                            Habitantes=80

                                        },
                                        new AreaPolitica
                                        {
                                            nombre = "Alangasi",
                                            TipoArea = TipoArea.Parroquia,
                                            Habitantes= 50
                                        }
                                    }
                                },
                                new AreaPolitica
                                {
                                    nombre = "Rumiñahui",
                                    TipoArea = TipoArea.Canton,
                                    AreaPoliticas = new List<AreaPolitica>
                                    {
                                        new AreaPolitica
                                        {
                                            nombre = "Conocoto",
                                            TipoArea = TipoArea.Parroquia
                                        },
                                        new AreaPolitica
                                        {
                                            nombre = "ASAS",
                                            TipoArea = TipoArea.Parroquia,
                                            Habitantes=10
                                           
                                        }
                                    }
                                }
                            }
                        }
                }

            };
            System.Console.WriteLine (areaPolitica.ObtenerNumeroHabitantes());
        }
    }
}







