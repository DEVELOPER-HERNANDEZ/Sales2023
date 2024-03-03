
using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        public DataContext _context { get; }
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {


                _context.Countries.Add(new Country { Name = "Afganistán" });
                _context.Countries.Add(new Country { Name = "Albania" });
                _context.Countries.Add(new Country { Name = "Alemania" });
                _context.Countries.Add(new Country { Name = "Andorra" });
                _context.Countries.Add(new Country { Name = "Angola" });
                _context.Countries.Add(new Country { Name = "Antigua y Barbuda" });
                _context.Countries.Add(new Country { Name = "Arabia Saudita" });
                _context.Countries.Add(new Country { Name = "Argelia" });
                _context.Countries.Add(new Country { Name = "Argentina" });
                _context.Countries.Add(new Country { Name = "Armenia" });
                _context.Countries.Add(new Country { Name = "Australia" });
                _context.Countries.Add(new Country { Name = "Austria" });
                _context.Countries.Add(new Country { Name = "Azerbaiyán" });
                _context.Countries.Add(new Country { Name = "Bahamas" });
                _context.Countries.Add(new Country { Name = "Bangladés" });
                _context.Countries.Add(new Country { Name = "Barbados" });
                _context.Countries.Add(new Country { Name = "Baréin" });
                _context.Countries.Add(new Country { Name = "Bélgica" });
                _context.Countries.Add(new Country { Name = "Belice" });
                _context.Countries.Add(new Country { Name = "Benín" });
                _context.Countries.Add(new Country { Name = "Bielorrusia" });
                _context.Countries.Add(new Country { Name = "Birmania" });
                _context.Countries.Add(new Country { Name = "Bolivia" });
                _context.Countries.Add(new Country { Name = "Bosnia y Herzegovina" });
                _context.Countries.Add(new Country { Name = "Botsuana" });
                _context.Countries.Add(new Country { Name = "Brasil" });
                _context.Countries.Add(new Country { Name = "Brunéi" });
                _context.Countries.Add(new Country { Name = "Bulgaria" });
                _context.Countries.Add(new Country { Name = "Burkina Faso" });
                _context.Countries.Add(new Country { Name = "Burundi" });
                _context.Countries.Add(new Country { Name = "Bután" });
                _context.Countries.Add(new Country { Name = "Cabo Verde" });
                _context.Countries.Add(new Country { Name = "Camboya" });
                _context.Countries.Add(new Country { Name = "Camerún" });
                _context.Countries.Add(new Country { Name = "Canadá" });
                _context.Countries.Add(new Country { Name = "Catar" });
                _context.Countries.Add(new Country { Name = "Chad" });
                _context.Countries.Add(new Country { Name = "Chile" });
                _context.Countries.Add(new Country { Name = "China" });
                _context.Countries.Add(new Country { Name = "Chipre" });
                _context.Countries.Add(new Country { Name = "Ciudad del Vaticano" });
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Comoras" });
                _context.Countries.Add(new Country { Name = "Corea del Norte" });
                _context.Countries.Add(new Country { Name = "Corea del Sur" });
                _context.Countries.Add(new Country { Name = "Costa de Marfil" });
                _context.Countries.Add(new Country { Name = "Costa Rica" });
                _context.Countries.Add(new Country { Name = "Croacia" });
                _context.Countries.Add(new Country { Name = "Cuba" });
                _context.Countries.Add(new Country { Name = "Dinamarca" });
                _context.Countries.Add(new Country { Name = "Dominica" });
                _context.Countries.Add(new Country { Name = "Ecuador" });
                _context.Countries.Add(new Country { Name = "Egipto" });
                _context.Countries.Add(new Country { Name = "El Salvador" });
                _context.Countries.Add(new Country { Name = "Emiratos Árabes Unidos" });
                _context.Countries.Add(new Country { Name = "Eritrea" });
                _context.Countries.Add(new Country { Name = "Eslovaquia" });
                _context.Countries.Add(new Country { Name = "Eslovenia" });
                _context.Countries.Add(new Country { Name = "España" });
                _context.Countries.Add(new Country
                {
                    Name = "Estados Unidos",
                    States = new List<State>()
                    {
                    new State() { Name="Alabama"},
                    new State() { Name="Alaska"},
                    new State() { Name="Arizona"},
                    new State() { Name="Arkansas"},
                    new State() { Name="California"},
                    new State() { Name="Colorado"},
                    new State() { Name="Connecticut"},
                    new State() { Name="Delaware"},
                    new State() { Name="Florida"},
                    new State() { Name="Georgia"},
                    new State() { Name="Hawái"},
                    new State() { Name="Idaho"},
                    new State() { Name="Illinois"},
                    new State() { Name="Indiana"},
                    new State() { Name="Iowa"},
                    new State() { Name="Kansas"},
                    new State() { Name="Kentucky"},
                    new State() { Name="Luisiana"},
                    new State() { Name="Maine"},
                    new State() { Name="Maryland"},
                    new State() { Name="Massachusetts"},
                    new State() { Name="Míchigan"},
                    new State() { Name="Minnesota"},
                    new State() { Name="Misisipi"},
                    new State() { Name="Misuri"},
                    new State() { Name="Montana"},
                    new State() { Name="Nebraska"},
                    new State() { Name="Nevada"},
                    new State() { Name="Nuevo Hampshire"},
                    new State() { Name="Nueva Jersey"},
                    new State() { Name="Nuevo México"},
                    new State() { Name="Nueva York"},
                    new State() { Name="Carolina del Norte"},
                    new State() { Name="Dakota del Norte"},
                    new State() { Name="Ohio"},
                    new State() { Name="Oklahoma"},
                    new State() { Name="Oregón"},
                    new State() { Name="Pensilvania"},
                    new State() { Name="Rhode Island"},
                    new State() { Name="Carolina del Sur"},
                    new State() { Name="Dakota del Sur" },
                    new State() { Name="Tennessee"},
                    new State() 
                    { 
                        Name="Texas",
                        Cities = new List<City>()
                        {
                            new City() { Name="Houston"},
                            new City() { Name="San Antonio"},
                            new City() { Name="Dallas"},
                            new City() { Name="El Paso"}
                        }
                    },
                    new State() { Name="Utah"},
                    new State() { Name="Vermont"},
                    new State() { Name="Virginia"},
                    new State() { Name="Washington"},
                    new State() { Name="Virginia Occidental"},
                    new State() { Name="Wisconsin"},
                    new State() { Name="Wyoming"}

                    }
                });
                _context.Countries.Add(new Country { Name = "Estonia" });
                _context.Countries.Add(new Country { Name = "Etiopía" });
                _context.Countries.Add(new Country { Name = "Filipinas" });
                _context.Countries.Add(new Country { Name = "Finlandia" });
                _context.Countries.Add(new Country { Name = "Fiyi" });
                _context.Countries.Add(new Country { Name = "Francia" });
                _context.Countries.Add(new Country { Name = "Gabón" });
                _context.Countries.Add(new Country { Name = "Gambia" });
                _context.Countries.Add(new Country { Name = "Georgia" });
                _context.Countries.Add(new Country { Name = "Ghana" });
                _context.Countries.Add(new Country { Name = "Granada" });
                _context.Countries.Add(new Country { Name = "Grecia" });
                _context.Countries.Add(new Country { Name = "Guatemala" });
                _context.Countries.Add(new Country { Name = "Guyana" });
                _context.Countries.Add(new Country { Name = "Guinea" });
                _context.Countries.Add(new Country { Name = "Guinea ecuatorial" });
                _context.Countries.Add(new Country { Name = "Guinea-Bisáu" });
                _context.Countries.Add(new Country { Name = "Haití" });
                _context.Countries.Add(new Country { Name = "Honduras" });
                _context.Countries.Add(new Country { Name = "Hungría" });
                _context.Countries.Add(new Country { Name = "India" });
                _context.Countries.Add(new Country { Name = "Indonesia" });
                _context.Countries.Add(new Country { Name = "Irak" });
                _context.Countries.Add(new Country { Name = "Irán" });
                _context.Countries.Add(new Country { Name = "Irlanda" });
                _context.Countries.Add(new Country { Name = "Islandia" });
                _context.Countries.Add(new Country { Name = "Islas Marshall" });
                _context.Countries.Add(new Country { Name = "Islas Salomón" });
                _context.Countries.Add(new Country { Name = "Israel" });
                _context.Countries.Add(new Country { Name = "Italia" });
                _context.Countries.Add(new Country { Name = "Jamaica" });
                _context.Countries.Add(new Country { Name = "Japón" });
                _context.Countries.Add(new Country { Name = "Jordania" });
                _context.Countries.Add(new Country { Name = "Kazajistán" });
                _context.Countries.Add(new Country { Name = "Kenia" });
                _context.Countries.Add(new Country { Name = "Kirguistán" });
                _context.Countries.Add(new Country { Name = "Kiribati" });
                _context.Countries.Add(new Country { Name = "Kuwait" });
                _context.Countries.Add(new Country { Name = "Laos" });
                _context.Countries.Add(new Country { Name = "Lesoto" });
                _context.Countries.Add(new Country { Name = "Letonia" });
                _context.Countries.Add(new Country { Name = "Líbano" });
                _context.Countries.Add(new Country { Name = "Liberia" });
                _context.Countries.Add(new Country { Name = "Libia" });
                _context.Countries.Add(new Country { Name = "Liechtenstein" });
                _context.Countries.Add(new Country { Name = "Lituania" });
                _context.Countries.Add(new Country { Name = "Luxemburgo" });
                _context.Countries.Add(new Country { Name = "Macedonia del Norte" });
                _context.Countries.Add(new Country { Name = "Madagascar" });
                _context.Countries.Add(new Country { Name = "Malasia" });
                _context.Countries.Add(new Country { Name = "Malaui" });
                _context.Countries.Add(new Country { Name = "Maldivas" });
                _context.Countries.Add(new Country { Name = "Malí" });
                _context.Countries.Add(new Country { Name = "Malta" });
                _context.Countries.Add(new Country { Name = "Marruecos" });
                _context.Countries.Add(new Country { Name = "Mauricio" });
                _context.Countries.Add(new Country { Name = "Mauritania" });

                _context.Countries.Add(new Country
                {
                    Name = "México",
                    States = new List<State>()
                     {
                        new State { Name = "Aguascalientes" },
                        new State { Name = "Baja California" },
                        new State { Name = "Baja California Sur" },
                        new State { Name = "Campeche" },
                        new State { Name = "Chiapas" },
                        new State { Name = "Chihuahua" },
                        new State { Name = "Ciudad de México" },
                        new State { Name = "Coahuila" },
                        new State { Name = "Colima" },
                        new State { Name = "Durango" },
                        new State { Name = "Estado de México" },
                        new State { Name = "Guanajuato" },
                        new State { Name = "Guerrero" },
                        new State { Name = "Hidalgo" },
                        new State { Name = "Jalisco" },
                        new State { Name = "Michoacán" },
                        new State { Name = "Morelos" },
                        new State { Name = "Nayarit" },
                        new State { Name = "Nuevo León" },
                        new State { Name = "Oaxaca" },
                        new State { Name = "Puebla" },
                        new State { Name = "Querétaro" },
                        new State { Name = "Quintana Roo" },
                        new State { Name = "San Luis Potosí" },
                        new State { Name = "Sinaloa" },
                        new State { Name = "Sonora" },
                        new State { Name = "Tabasco" },
                        new State { Name = "Tamaulipas" },
                        new State { Name = "Tlaxcala" },
                        new State { Name = "Veracruz" },
                        new State { Name = "Yucatán" },
                        new State { Name = "Zacatecas" }
                        }
                });



                _context.Countries.Add(new Country { Name = "Micronesia" });
                _context.Countries.Add(new Country { Name = "Moldavia" });
                _context.Countries.Add(new Country { Name = "Mónaco" });
                _context.Countries.Add(new Country { Name = "Mongolia" });
                _context.Countries.Add(new Country { Name = "Montenegro" });
                _context.Countries.Add(new Country { Name = "Mozambique" });
                _context.Countries.Add(new Country { Name = "Namibia" });
                _context.Countries.Add(new Country { Name = "Nauru" });
                _context.Countries.Add(new Country { Name = "Nepal" });
                _context.Countries.Add(new Country { Name = "Nicaragua" });
                _context.Countries.Add(new Country { Name = "Níger" });
                _context.Countries.Add(new Country { Name = "Nigeria" });
                _context.Countries.Add(new Country { Name = "Noruega" });
                _context.Countries.Add(new Country { Name = "Nueva Zelanda" });
                _context.Countries.Add(new Country { Name = "Omán" });
                _context.Countries.Add(new Country { Name = "Países Bajos" });
                _context.Countries.Add(new Country { Name = "Pakistán" });
                _context.Countries.Add(new Country { Name = "Palaos" });
                _context.Countries.Add(new Country { Name = "Panamá" });
                _context.Countries.Add(new Country { Name = "Papúa Nueva Guinea" });
                _context.Countries.Add(new Country { Name = "Paraguay" });
                _context.Countries.Add(new Country { Name = "Perú" });
                _context.Countries.Add(new Country { Name = "Polonia" });
                _context.Countries.Add(new Country { Name = "Portugal" });
                _context.Countries.Add(new Country { Name = "Reino Unido" });
                _context.Countries.Add(new Country { Name = "República Centroafricana" });
                _context.Countries.Add(new Country { Name = "República Checa" });
                _context.Countries.Add(new Country { Name = "República del Congo" });
                _context.Countries.Add(new Country { Name = "República Democrática del Congo" });
                _context.Countries.Add(new Country { Name = "República Dominicana" });
                _context.Countries.Add(new Country { Name = "Ruanda" });
                _context.Countries.Add(new Country { Name = "Rumanía" });
                _context.Countries.Add(new Country { Name = "Rusia" });
                _context.Countries.Add(new Country { Name = "Samoa" });
                _context.Countries.Add(new Country { Name = "San Cristóbal y Nieves" });
                _context.Countries.Add(new Country { Name = "San Marino" });
                _context.Countries.Add(new Country { Name = "San Vicente y las Granadinas" });
                _context.Countries.Add(new Country { Name = "Santa Lucía" });
                _context.Countries.Add(new Country { Name = "Santo Tomé y Príncipe" });
                _context.Countries.Add(new Country { Name = "Senegal" });
                _context.Countries.Add(new Country { Name = "Serbia" });
                _context.Countries.Add(new Country { Name = "Seychelles" });
                _context.Countries.Add(new Country { Name = "Sierra Leona" });
                _context.Countries.Add(new Country { Name = "Singapur" });
                _context.Countries.Add(new Country { Name = "Siria" });
                _context.Countries.Add(new Country { Name = "Somalia" });
                _context.Countries.Add(new Country { Name = "Sri Lanka" });
                _context.Countries.Add(new Country { Name = "Suazilandia" });
                _context.Countries.Add(new Country { Name = "Sudáfrica" });
                _context.Countries.Add(new Country { Name = "Sudán" });
                _context.Countries.Add(new Country { Name = "Sudán del Sur" });
                _context.Countries.Add(new Country { Name = "Suecia" });
                _context.Countries.Add(new Country { Name = "Suiza" });
                _context.Countries.Add(new Country { Name = "Surinam" });
                _context.Countries.Add(new Country { Name = "Tailandia" });
                _context.Countries.Add(new Country { Name = "Tanzania" });
                _context.Countries.Add(new Country { Name = "Tayikistán" });
                _context.Countries.Add(new Country { Name = "Timor Oriental" });
                _context.Countries.Add(new Country { Name = "Togo" });
                _context.Countries.Add(new Country { Name = "Tonga" });
                _context.Countries.Add(new Country { Name = "Trinidad y Tobago" });
                _context.Countries.Add(new Country { Name = "Túnez" });
                _context.Countries.Add(new Country { Name = "Turkmenistán" });
                _context.Countries.Add(new Country { Name = "Turquía" });
                _context.Countries.Add(new Country { Name = "Tuvalu" });
                _context.Countries.Add(new Country { Name = "Ucrania" });
                _context.Countries.Add(new Country { Name = "Uganda" });
                _context.Countries.Add(new Country { Name = "Uruguay" });
                _context.Countries.Add(new Country { Name = "Uzbekistán" });
                _context.Countries.Add(new Country { Name = "Vanuatu" });
                _context.Countries.Add(new Country { Name = "Venezuela" });
                _context.Countries.Add(new Country { Name = "Vietnam" });
                _context.Countries.Add(new Country { Name = "Yemen" });
                _context.Countries.Add(new Country { Name = "Yibuti" });
                _context.Countries.Add(new Country { Name = "Zambia" });
                _context.Countries.Add(new Country { Name = "Zimbabue" });
                await _context.SaveChangesAsync();

            }
        }
    }
}
