using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Gestor_Contactos_Dallian.Model;

namespace Gestor_Contactos_Dallian.ViewModel
{

   
    internal class PaisViewModel
    {

         public IList<Country> ListaPaises { get; set; }

        public PaisViewModel() {

            try
            {

                ListaPaises = new ObservableCollection<Country>();
                ListaPaises.Add(new Country { Nome = "Afeganistão",    Source = "Afeganistao" });
                ListaPaises.Add(new Country { Nome = "África do Sul",   Source = "AfricadoSul" });
                ListaPaises.Add(new Country { Nome = "Albânia",             Source = "Albania" });
                ListaPaises.Add(new Country { Nome = "Alemanha",             Source = "Alemanha" });
                ListaPaises.Add(new Country { Nome = "Andorra",              Source = "Andorra" });
                ListaPaises.Add(new Country { Nome = "Angola",                Source = "Angola" });
                ListaPaises.Add(new Country { Nome = "Antiga e Barbuda", Source = "AntigaeBarbuda" });
                ListaPaises.Add(new Country { Nome = "Arábia Saudita",        Source = "ArabiaSaudita" });
                ListaPaises.Add(new Country { Nome = "Argelia",              Source = "Argelia" });
                ListaPaises.Add(new Country { Nome = "Arménia",              Source = "Armenia" });
                ListaPaises.Add(new Country { Nome = "Austrália",            Source = "Australia" });
                ListaPaises.Add(new Country { Nome = "Áustria",              Source = "Austria" });
                ListaPaises.Add(new Country { Nome = "Azerbaijão",           Source = "Azerbaijao" });
                ListaPaises.Add(new Country { Nome = "Bahamas",              Source = "Bahamas" });
                ListaPaises.Add(new Country { Nome = "Bangladexe",                    Source = "Bangladexe" });
                ListaPaises.Add(new Country { Nome = "Barbados",                       Source = "Barbados" });
                ListaPaises.Add(new Country { Nome = "Barém",                          Source = "Barem" });
                ListaPaises.Add(new Country { Nome = "Bélgica",                        Source = "Belgica" });
                ListaPaises.Add(new Country { Nome = "Belize",                         Source = "Belize" });
                ListaPaises.Add(new Country { Nome = "Benim",                          Source = "Benim" });
                ListaPaises.Add(new Country { Nome = "Bielorrússia",                   Source = "Bielorrussia" });
                ListaPaises.Add(new Country { Nome = "Bolívia",                        Source = "Bolivia" });
                ListaPaises.Add(new Country { Nome = "Bósnia e Herzegovina",           Source = "BosniaeHerzegovina" });
                ListaPaises.Add(new Country { Nome = "Botsuana",                       Source = "Botsuana" });
                ListaPaises.Add(new Country { Nome = "Brasil",                         Source = "Brasil" });
                ListaPaises.Add(new Country { Nome = "Brunei",                         Source = "Brunei" });
                ListaPaises.Add(new Country { Nome = "Bulgária",                       Source = "Bulgaria" });
                ListaPaises.Add(new Country { Nome = "Burquina Faso",                  Source = "BurquinaFaso" });
                ListaPaises.Add(new Country { Nome = "Burúndi",                        Source = "Burundi" });
                ListaPaises.Add(new Country { Nome = "Butão",                          Source = "Butao" });
                ListaPaises.Add(new Country { Nome = "Cabo Verde",                     Source = "Cabo Verde" });
                ListaPaises.Add(new Country { Nome = "Camarões",                       Source = "Camaroes" });
                ListaPaises.Add(new Country { Nome = "Camboja",                        Source = "Camboja" });
                ListaPaises.Add(new Country { Nome = "Canadá",                         Source = "Canada" });
                ListaPaises.Add(new Country { Nome = "Catar",                          Source = "Catar" });
                ListaPaises.Add(new Country { Nome = "Cazaquistão",                    Source = "Cazaquistao" });
                ListaPaises.Add(new Country { Nome = "Chade",                          Source = "Chade" });
                ListaPaises.Add(new Country { Nome = "Chile",                          Source = "Chile" });
                ListaPaises.Add(new Country { Nome = "China",                          Source = "China" });
                ListaPaises.Add(new Country { Nome = "Chipre",                         Source = "Chipre" });
                ListaPaises.Add(new Country { Nome = "Colômbia",                       Source = "Colombia" });
                ListaPaises.Add(new Country { Nome = "Comores",                        Source = "Comores" });
                ListaPaises.Add(new Country { Nome = "Congo-Brazzaville",              Source = "Congo-Brazzaville" });
                ListaPaises.Add(new Country { Nome = "Coreia do Norte",                Source = "CoreiadoNorte" });
                ListaPaises.Add(new Country { Nome = "Coreia do Sul",                  Source = "CoreiadoSul" });
                ListaPaises.Add(new Country { Nome = "Cosovo",                         Source = "Cosovo" });
                ListaPaises.Add(new Country { Nome = "Costa do Marfim",                Source = "CostadoMarfim" });
                ListaPaises.Add(new Country { Nome = "Costa Rica",                     Source = "CostaRica" });
                ListaPaises.Add(new Country { Nome = "Croácia",                        Source = "Croacia" });
                ListaPaises.Add(new Country { Nome = "Cuaite",                         Source = "Cuaite" });
                ListaPaises.Add(new Country { Nome = "Cuba",                           Source = "Cuba" });
                ListaPaises.Add(new Country { Nome = "Dinamarca",                      Source = "Dinamarca" });
                ListaPaises.Add(new Country { Nome = "Dominica",                       Source = "Dominica" });
                ListaPaises.Add(new Country { Nome = "Egito",                          Source = "Egito" });
                ListaPaises.Add(new Country { Nome = "Emirados Árabes Unidos",         Source = "EmiradosArabesUnidos" });
                ListaPaises.Add(new Country { Nome = "Equador",                        Source = "Equador" });
                ListaPaises.Add(new Country { Nome = "Eritreia",                       Source = "Eritreia" });
                ListaPaises.Add(new Country { Nome = "Eslováquia",                     Source = "Eslovaquia" });
                ListaPaises.Add(new Country { Nome = "Eslovénia",                      Source = "Eslovenia" });
                ListaPaises.Add(new Country { Nome = "Espanha",                        Source = "Espanha" });
                ListaPaises.Add(new Country { Nome = "Essuatíni",                      Source = "Essuatini" });
                ListaPaises.Add(new Country { Nome = "Estado da Palestina",            Source = "EstadodaPalestina" });
                ListaPaises.Add(new Country { Nome = "Estados Unidos",                 Source = "EstadosUnidos" });
                ListaPaises.Add(new Country { Nome = "Estónia",                        Source = "Estonia" });
                ListaPaises.Add(new Country { Nome = "Etiópia",                        Source = "Etiopia" });
                ListaPaises.Add(new Country { Nome = "Fiji",                           Source = "Fiji" });
                ListaPaises.Add(new Country { Nome = "Filipinas",                      Source = "Filipinas" });
                ListaPaises.Add(new Country { Nome = "Finlândia",                      Source = "Finlandia" });
                ListaPaises.Add(new Country { Nome = "França",                         Source = "Franca" });
                ListaPaises.Add(new Country { Nome = "Gabão",                          Source = "Gabao" });
                ListaPaises.Add(new Country { Nome = "Gâmbia",                         Source = "Gambia" });
                ListaPaises.Add(new Country { Nome = "Gana",                           Source = "Gana" });
                ListaPaises.Add(new Country { Nome = "Geórgia",                        Source = "Georgia" });
                ListaPaises.Add(new Country { Nome = "Granada",                        Source = "Granada" });
                ListaPaises.Add(new Country { Nome = "Grécia",                         Source = "Grecia" });
                ListaPaises.Add(new Country { Nome = "Guatemala",                      Source = "Guatemala" });
                ListaPaises.Add(new Country { Nome = "Guiana",                         Source = "Guiana" });
                ListaPaises.Add(new Country { Nome = "Guiné", Source = "Guine" });
                ListaPaises.Add(new Country { Nome = "Guiné Equatorial",                            Source ="GuineEquatorial" });
                ListaPaises.Add(new Country { Nome = "Guiné-Bissau",                                 Source ="GuineBissau" });
                ListaPaises.Add(new Country { Nome = "Haiti",                                        Source ="Haiti" });
                ListaPaises.Add(new Country { Nome = "Honduras",                                     Source ="Honduras" });
                ListaPaises.Add(new Country { Nome = "Hungria",                                      Source ="Hungria" });
                ListaPaises.Add(new Country { Nome = "Iémen",                                        Source ="Iemen" });
                ListaPaises.Add(new Country { Nome = "Ilhas Marechal",                               Source ="IlhasMarechal" });
                ListaPaises.Add(new Country { Nome = "Índia",                                        Source ="India" });
                ListaPaises.Add(new Country { Nome = "Indonésia",                                    Source ="Indonesia" });
                ListaPaises.Add(new Country { Nome = "Irão",                                         Source ="Irao" });
                ListaPaises.Add(new Country { Nome = "Iraque",                                       Source ="Iraque" });
                ListaPaises.Add(new Country { Nome = "Irlanda",                                      Source ="Irlanda" });
                ListaPaises.Add(new Country { Nome = "Islândia",                                     Source ="Islandia" });
                ListaPaises.Add(new Country { Nome = "Israel",                                       Source ="Israel" });
                ListaPaises.Add(new Country { Nome = "Itália",                                       Source ="Italia" });
                ListaPaises.Add(new Country { Nome = "Jamaica",                                      Source ="Jamaica" });
                ListaPaises.Add(new Country { Nome = "Japão",                                        Source ="Japao" });
                ListaPaises.Add(new Country { Nome = "Jibuti",                                       Source ="Jibuti" });
                ListaPaises.Add(new Country { Nome = "Jordânia",                                     Source ="Jordania" });
                ListaPaises.Add(new Country { Nome = "Laus",                                         Source ="Laus" });
                ListaPaises.Add(new Country { Nome = "Lesoto",                                       Source ="Lesoto" });
                ListaPaises.Add(new Country { Nome = "Letónia",                                      Source ="Letonia" });
                ListaPaises.Add(new Country { Nome = "Líbano",                                       Source ="Libano" });
                ListaPaises.Add(new Country { Nome = "Libéria",                                      Source ="Liberia" });
                ListaPaises.Add(new Country { Nome = "Líbia",                                        Source ="Libia" });
                ListaPaises.Add(new Country { Nome = "Listenstaine",                                 Source ="Listenstaine" });
                ListaPaises.Add(new Country { Nome = "Lituânia",                                     Source ="Lituania" });
                ListaPaises.Add(new Country { Nome = "Luxemburgo",                                   Source ="Luxemburgo" });
                ListaPaises.Add(new Country { Nome = "Macedónia do Norte",                           Source ="MacedoniadoNorte" });
                ListaPaises.Add(new Country { Nome = "Madagáscar",                                   Source ="Madagascar" });
                ListaPaises.Add(new Country { Nome = "Malásia",                                      Source ="Malasia" });
                ListaPaises.Add(new Country { Nome = "Maláui",                                       Source ="Malaui" });
                ListaPaises.Add(new Country { Nome = "Maldivas",                                     Source ="Maldivas" });
                ListaPaises.Add(new Country { Nome = "Mali",                                         Source ="Mali" });
                ListaPaises.Add(new Country { Nome = "Malta",                                        Source ="Malta" });
                ListaPaises.Add(new Country { Nome = "Marrocos",                                     Source ="Marrocos" });
                ListaPaises.Add(new Country { Nome = "Maurícia",                                     Source ="Mauricia" });
                ListaPaises.Add(new Country { Nome = "Mauritânia",                                   Source ="Mauritania" });
                ListaPaises.Add(new Country { Nome = "México",                                       Source ="Mexico" });
                ListaPaises.Add(new Country { Nome = "Mianmar",                                      Source ="Mianmar" });
                ListaPaises.Add(new Country { Nome = "Micronésia",                                   Source ="Micronesia" });
                ListaPaises.Add(new Country { Nome = "Moçambique",                                   Source ="Mocambique" });
                ListaPaises.Add(new Country { Nome = "Moldávia",                                     Source ="Moldavia" });
                ListaPaises.Add(new Country { Nome = "Mónaco",                                       Source ="Monaco" });
                ListaPaises.Add(new Country { Nome = "Mongólia",                                     Source ="Mongolia" });
                ListaPaises.Add(new Country { Nome = "Montenegro",                                   Source ="Montenegro" });
                ListaPaises.Add(new Country { Nome = "Namíbia",                                      Source ="Namibia" });
                ListaPaises.Add(new Country { Nome = "Nauru",                                        Source ="Nauru" });
                ListaPaises.Add(new Country { Nome = "Nepal",                                        Source ="Nepal" });
                ListaPaises.Add(new Country { Nome = "Nicarágua",                                    Source ="Nicaragua" });
                ListaPaises.Add(new Country { Nome = "Níger",                                        Source ="Niger" });
                ListaPaises.Add(new Country { Nome = "Nigéria",                                      Source ="Nigeria" });
                ListaPaises.Add(new Country { Nome = "Noruega",                                      Source ="Noruega" });
                ListaPaises.Add(new Country { Nome = "Nova Zelândia",                                Source ="Nova Zelandia" });
                ListaPaises.Add(new Country { Nome = "Omã",                                          Source ="Oma" });
                ListaPaises.Add(new Country { Nome = "Países Baixos",                                Source ="Paises Baixos" });
                ListaPaises.Add(new Country { Nome = "Palau",                                        Source ="Palau" });
                ListaPaises.Add(new Country { Nome = "Panamá",                                       Source ="Panama" });
                ListaPaises.Add(new Country { Nome = "Papua Nova Guiné",                             Source ="Papua Nova Guine" });
                ListaPaises.Add(new Country { Nome = "Paquistão",                                    Source ="Paquistao" });
                ListaPaises.Add(new Country { Nome = "Paraguai",                                     Source ="Paraguai" });
                ListaPaises.Add(new Country { Nome = "Peru",                                         Source ="Peru" });
                ListaPaises.Add(new Country { Nome = "Polónia",                                      Source ="Polonia" });
                ListaPaises.Add(new Country { Nome = "Portugal", Source ="Portugal" });
                ListaPaises.Add(new Country { Nome = "Quénia",                                    Source ="Quenia" });
                ListaPaises.Add(new Country { Nome = "Quirguistão",                                Source ="Quirguistao" });
                ListaPaises.Add(new Country { Nome = "Quiribáti",                                  Source ="Quiribati" });
                ListaPaises.Add(new Country { Nome = "Reino Unido",                                Source ="ReinoUnido" });
                ListaPaises.Add(new Country { Nome = "República Centro-Africana",                  Source ="RepublicaCentroAfricana" });
                ListaPaises.Add(new Country { Nome = "República Checa",                            Source ="RepublicaCheca" });
                ListaPaises.Add(new Country { Nome = "República Democrática do Congo",             Source ="RepublicaDemocraticadoCongo" });
                ListaPaises.Add(new Country { Nome = "República Dominicana",                       Source ="RepublicaDominicana" });
                ListaPaises.Add(new Country { Nome = "Roménia",                                    Source ="Romenia" });
                ListaPaises.Add(new Country { Nome = "Ruanda",                                     Source ="Ruanda" });
                ListaPaises.Add(new Country { Nome = "Rússia",                                     Source ="Russia" });
                ListaPaises.Add(new Country { Nome = "Salomão",                                    Source ="Salomao" });
                ListaPaises.Add(new Country { Nome = "Salvador",                                   Source ="Salvador" });
                ListaPaises.Add(new Country { Nome = "Samoa",                                      Source ="Samoa" });
                ListaPaises.Add(new Country { Nome = "Santa Lúcia",                                Source ="SantaLucia" });
                ListaPaises.Add(new Country { Nome = "São Cristóvão e Neves",                      Source ="SaoCristovaoeNeves" });
                ListaPaises.Add(new Country { Nome = "São Marinho",                                Source ="SaoMarinho" });
                ListaPaises.Add(new Country { Nome = "São Tomé e Príncipe",                        Source ="SaoTomeePrincipe" });
                ListaPaises.Add(new Country { Nome = "São Vicente e Granadinas",                   Source ="SaoVicenteeGranadinas" });
                ListaPaises.Add(new Country { Nome = "Seicheles",                                  Source ="Seicheles" });
                ListaPaises.Add(new Country { Nome = "Senegal",                                    Source ="Senegal" });
                ListaPaises.Add(new Country { Nome = "Serra Leoa",                                 Source ="Serra Leoa" });
                ListaPaises.Add(new Country { Nome = "Sérvia",                                     Source ="Servia" });
                ListaPaises.Add(new Country { Nome = "Singapura",                                  Source ="Singapura" });
                ListaPaises.Add(new Country { Nome = "Síria",                                      Source ="Siria" });
                ListaPaises.Add(new Country { Nome = "Somália",                                    Source ="Somalia" });
                ListaPaises.Add(new Country { Nome = "Sri Lanca",                                  Source ="SriLanca" });
                ListaPaises.Add(new Country { Nome = "Sudão", Source ="Sudao" });
                ListaPaises.Add(new Country { Nome = "Sudão do Sul",             Source ="SudaodoSul" });
                ListaPaises.Add(new Country { Nome = "Suécia",                    Source ="Suecia" });
                ListaPaises.Add(new Country { Nome = "Suíça",                     Source ="Suica" });
                ListaPaises.Add(new Country { Nome = "Suriname",                  Source ="Suriname" });
                ListaPaises.Add(new Country { Nome = "Tailândia",                 Source ="Tailandia" });
                ListaPaises.Add(new Country { Nome = "Taiuã",                     Source ="Taiua" });
                ListaPaises.Add(new Country { Nome = "Tajiquistão",               Source ="Tajiquistao" });
                ListaPaises.Add(new Country { Nome = "Tanzânia",                  Source ="Tanzania" });
                ListaPaises.Add(new Country { Nome = "Timor-Leste",               Source ="TimorLeste" });
                ListaPaises.Add(new Country { Nome = "Togo",                      Source ="Togo" });
                ListaPaises.Add(new Country { Nome = "Tonga",                     Source ="Tonga" });
                ListaPaises.Add(new Country { Nome = "Trindade e Tobago",         Source ="TrindadeeTobago" });
                ListaPaises.Add(new Country { Nome = "Tunísia",                   Source ="Tunisia" });
                ListaPaises.Add(new Country { Nome = "Turcomenistão",             Source ="Turcomenistao" });
                ListaPaises.Add(new Country { Nome = "Turquia",                   Source ="Turquia" });
                ListaPaises.Add(new Country { Nome = "Tuvalu",                    Source ="Tuvalu" });
                ListaPaises.Add(new Country { Nome = "Ucrânia",                   Source ="Ucrania" });
                ListaPaises.Add(new Country { Nome = "Uganda",                    Source ="Uganda" });
                ListaPaises.Add(new Country { Nome = "Uruguai",                   Source ="Uruguai" });
                ListaPaises.Add(new Country { Nome = "Usbequistão",               Source ="Usbequistao" });
                ListaPaises.Add(new Country { Nome = "Vanuatu",                   Source ="Vanuatu" });
                ListaPaises.Add(new Country { Nome = "Vaticano",                  Source ="Vaticano" });
                ListaPaises.Add(new Country { Nome = "Venezuela",                 Source ="Venezuela" });
                ListaPaises.Add(new Country { Nome = "Vietname",                  Source ="Vietname" });
                ListaPaises.Add(new Country { Nome = "Zâmbia",                    Source ="Zambia" });
                ListaPaises.Add(new Country { Nome = "Zimbábue", Source ="Zimbabue" });
                

            }
            catch(Exception)
            {

            }

        }


    }
}
