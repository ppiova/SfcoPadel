using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SfcoPadel.Data.Courts;
using SfcoPadel.Domain.Courts;

namespace SfcoPadel.Framework.DataSources
{
    public class InMemoryCourtsSource : ICourtsSource
    {
        public async Task<IReadOnlyList<Court>> GetAll()
        {
            await Task.Delay(1000);
            return new List<Court>
            {
                    new Court{
                        Id = 1,
                        Latitude = -31.415674,
                        Longitude = -62.115513,
                        Name = "Club Atlético Antartida Argentina",
                        Address = "Av. Juan de Garay 4500",
                        Blindex = true,
                        Indoor = false,
                        Price = "$ 200",
                        Images = new List<CourtImage>{
                            new CourtImage {
                                Url = "https://raw.githubusercontent.com/ppiova/SfcoPadelImages/main/01-ClubAtleticoAntartidaArgentina/01-01.PNG"
                            },
                            new CourtImage {
                                Url = "https://raw.githubusercontent.com/ppiova/SfcoPadelImages/main/01-ClubAtleticoAntartidaArgentina/01-02.PNG"
                            },
                            new CourtImage {
                                Url = "https://raw.githubusercontent.com/ppiova/SfcoPadelImages/main/01-ClubAtleticoAntartidaArgentina/01-03.PNG"
                            }
                        },
                        Phones = new List<CourtPhone>{
                            new CourtPhone{ Number = "+549-001-0000"},
                            new CourtPhone{ Number = "+549-002-0000"},
                            new CourtPhone{ Number = "+549-004-0000"}

                        }
                      
                    },
                    new Court{
                        Id = 3,
                        Latitude = -31.421835,
                        Longitude = -62.076131,
                        Name = "Sport Automovil Club",
                        Address = "Av. Urquiza 599",
                        Blindex = false,
                        Indoor = false,
                        Price = "$ 200",
                        Images = new List<CourtImage>{
                            new CourtImage {
                                Url = "https://c2.peakpx.com/wallpaper/604/823/790/castle-fortress-defense-architecture-wallpaper-preview.jpg"
                            }

                        },
                        Phones = new List<CourtPhone>{
                            new CourtPhone{ Number = "+543564423000"}
                          

                        },
                    },
                    new Court{
                        Id = 4,
                        Latitude = -31.421297,
                        Longitude = -62.076131,
                        Name = "Open Padel San Francisco",
                        Address = "Av. Garibaldi 1099-1001",
                        Blindex = true,
                        Indoor = false,
                        Price = "$ 200",
                        Images = new List<CourtImage>{
                           new CourtImage {
                                Url = "https://raw.githubusercontent.com/ppiova/SfcoPadelImages/main/04-OpenPadelSanFrancisco/04-01.PNG"
                            },
                            new CourtImage {
                                Url =  "https://raw.githubusercontent.com/ppiova/SfcoPadelImages/main/04-OpenPadelSanFrancisco/04-02.PNG"
                            },
                            new CourtImage {
                                Url = "https://raw.githubusercontent.com/ppiova/SfcoPadelImages/main/04-OpenPadelSanFrancisco/04-03.PNG"
                            }
                        },
                        Phones = new List<CourtPhone>()



                    },


            };
        }
    }
}
